using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;
        /// <summary>
        /// Inicializa la cola de clientes y El puesto de atencion como la caja 1
        /// </summary>
        private Negocio()
        {

            clientes = new Queue<Cliente>();
            caja = new PuestoAtencion(0);
        }
        public Negocio(string nombre) :this()
        {
            this.nombre = nombre;
        }
        public Cliente Cliente
        {
            get 
            {
                return this.clientes.Dequeue();

            }
            set 
            {
                if(!(this.clientes.Contains(value)))
                {
                    this.clientes.Enqueue(value);
                }
            }
        }

        public static bool operator ==(Negocio negocio,Cliente cliente)
        {
            foreach (Cliente cliente1 in negocio.clientes)
            {
                if(cliente1 == cliente)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Negocio negocio,Cliente cliente)
        {
            return !(negocio.clientes.Contains(cliente));
        }
        public static bool operator +(Negocio negocio,Cliente cliente)
        {
            if(negocio!=cliente)
            {
                negocio.clientes.Enqueue(cliente);
                return true;
            }
            return false;
        }

        public static bool operator ~(Negocio negocio)
        {
            return negocio.caja.AtenderCliente(negocio.Cliente);

        }
    }
}
