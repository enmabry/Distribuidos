using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Libreria; // o LibreriaRemota según tu namespace

namespace Servidor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Creamos el servidor TCP
            TcpListener servidor = new TcpListener(IPAddress.Any, 12345);
            servidor.Start();
            Console.WriteLine("Servidor de conversión iniciado en el puerto 12345...");

            while (true)
            {
                // Aceptamos una conexión de cliente
                TcpClient cliente = servidor.AcceptTcpClient();

                //  Creamos un hilo para atenderlo (multithreading)
                Thread hiloCliente = new Thread(() => AtenderCliente(cliente));
                hiloCliente.Start();
            }
        }

        static void AtenderCliente(TcpClient cliente)
        {
            try
            {
                NetworkStream stream = cliente.GetStream();

                //  Recibir XML del cliente
                byte[] buffer = new byte[4096];
                int bytesLeidos = stream.Read(buffer, 0, buffer.Length);
                string xmlSolicitud = Encoding.UTF8.GetString(buffer, 0, bytesLeidos);

                Console.WriteLine($"\nSolicitud recibida:\n{xmlSolicitud}\n");

                //  Procesar usando tu clase Conversor
                var conversor = new Conversor();
                string xmlRespuesta = conversor.Convertir(xmlSolicitud);

                //  Enviar la respuesta
                byte[] data = Encoding.UTF8.GetBytes(xmlRespuesta);
                stream.Write(data, 0, data.Length);

                Console.WriteLine($"Respuesta enviada al cliente.\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error con el cliente: {ex.Message}");
            }
            finally
            {
                cliente.Close();
            }
        }
    }
}
