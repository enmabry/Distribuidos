using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using Libreria; 

namespace ClienteFormulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento principal: clic en el botón "Convertir"
        private void btnConvertir_Click(object sender, EventArgs e)
        {

            try
            {
                // 1️⃣ Validar selección de monedas
                if (cmbDe.SelectedItem == null || cmbHacia.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione las monedas de origen y destino.", "Atención");
                    return;
                }

                // 2️⃣ Validar monto
                if (!decimal.TryParse(txtMonto.Text, out decimal monto))
                {
                    MessageBox.Show("Ingrese un monto válido.", "Atención");
                    return;
                }

                // 3️⃣ Crear la solicitud XML
                var solicitud = new Solicitud
                {
                    De = Enum.Parse<Moneda>(cmbDe.SelectedItem.ToString()),
                    Hacia = Enum.Parse<Moneda>(cmbHacia.SelectedItem.ToString()),
                    Unidades = monto
                };

                string xmlSolicitud = XmlHelper.SerializeToXml(solicitud);

                // 4️⃣ Conectarse al servidor
                using TcpClient cliente = new TcpClient("127.0.0.1", 12345);
                using NetworkStream stream = cliente.GetStream();

                // 5️⃣ Enviar el XML
                byte[] data = Encoding.UTF8.GetBytes(xmlSolicitud);
                stream.Write(data, 0, data.Length);

                // 6️⃣ Recibir respuesta
                byte[] buffer = new byte[4096];
                int bytesLeidos = stream.Read(buffer, 0, buffer.Length);
                string xmlRespuesta = Encoding.UTF8.GetString(buffer, 0, bytesLeidos);

                // 7️⃣ Deserializar respuesta
                var respuesta = XmlHelper.Deserialize<Respuesta>(xmlRespuesta);

                // 8️⃣ Mostrar resultado
                lblResultado.Text = $"Resultado: {respuesta.UnidadesConvertidas} {respuesta.Hacia}";
                lblTasa.Text = $"Tasa usada: {respuesta.Tasa}";
                lblFecha.Text = $"Fecha: {respuesta.Timestamp}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }
    }
}
