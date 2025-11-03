using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej03
{
    public class Entero
    {
        private int valor;
        public Entero(int valorInicial)
        {
            this.valor = valorInicial;
        }

        public int Cuadrado()
        {
            return this.valor * this.valor;
        }

        public int Cubo()
        {
            return this.valor * this.valor * this.valor;
        }

        public int GetValor()
        {
            return this.valor;
        }

        public void SetValor(int nuevoValor)
        {
            this.valor = nuevoValor;
        }

    }
}
