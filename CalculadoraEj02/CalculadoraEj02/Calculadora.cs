using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraEJ01
{
    public class Calculadora
    {
        public static int Sumar(int a, int b)
        {
            return a + b;
        }

        public static int Restar(int a, int b)
        {
            return a - b;
        }

        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public static double Dividir(int a, int b)
        {
            if (b == 0)
                return double.NaN;
            return a / b;
        }

    }
   
}
