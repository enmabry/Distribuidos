using System;

namespace CalculadoraEJ01
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==Calculadora Básica==");
            Console.WriteLine($"Suma: 5 + 3 = {Calculadora.Sumar(5,3)} ");
            Console.WriteLine($"Resta: 5 - 3 = {Calculadora.Restar(5, 3)} ");
            Console.WriteLine($"Multiplicación: 5 * 3 = {Calculadora.Multiplicar(5, 3)} ");
            Console.WriteLine($"División: 6/2 = {Calculadora.Dividir(6, 3)} ");
        }   
            
    }



}