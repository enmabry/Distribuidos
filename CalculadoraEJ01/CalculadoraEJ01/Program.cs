using System;

namespace CalculadoraEJ01
{

    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            Console.WriteLine("==Calculadora Básica==");
            Console.WriteLine($"Suma: 5 + 3 = {calculadora.Sumar(5,3)} ");
            Console.WriteLine($"Resta: 5 - 3 = {calculadora.Restar(5, 3)} ");
            Console.WriteLine($"Multiplicación: 5 * 3 = {calculadora.Multiplicar(5, 3)} ");
            Console.WriteLine($"División: 6/2 = {calculadora.Dividir(6, 3)} ");
        }   
            
    }



}