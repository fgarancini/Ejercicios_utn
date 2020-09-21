using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre) :this(numero)
        {
            this.Nombre = nombre;
        }
        public int Numero
        {
            get { return this.numero; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public static bool operator ==(Cliente cliente1, Cliente cliente2)
        {
            if(cliente1.Numero == cliente2.Numero)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Cliente cliente1, Cliente cliente2)
        {
            return !(cliente1.Numero == cliente2.Numero);
        }
    }
}
