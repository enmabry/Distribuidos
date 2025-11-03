using System;

namespace Ej03
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("==EJ03: Clase Entero==");

            Entero entero = new Entero(8);

            Console.WriteLine($"Valor inicial: {entero.GetValor()}");
            Console.WriteLine($"Cuadrado: {entero.Cuadrado()}");
            Console.WriteLine($"Cubo: {entero.Cubo()}");

            entero.SetValor(5);
            Console.WriteLine($"Nuevo valor: {entero.GetValor()}");
            Console.WriteLine($"Cuadrado: {entero.Cuadrado()}");
            Console.WriteLine($"Cubo: {entero.Cubo()}");

            Console.ReadKey();

        }


    }






}