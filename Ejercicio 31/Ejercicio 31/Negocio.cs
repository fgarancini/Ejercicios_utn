using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {

            this.Cliente = new Queue<Cliente>();
            caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }
        public Negocio(string nombre) :this()
        {
            this.nombre = nombre;
        }
        public Queue<Cliente> Cliente
        {
            get 
            {
                return this.clientes;

            }
            set 
            {
                clientes = value;
            }
        }

        public static bool operator ==(Negocio negocio,Cliente cliente)
        {
            if(negocio.clientes.Contains(cliente))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Negocio negocio,Cliente cliente)
        {
            return !(negocio.clientes.Contains(cliente));
        }
        public static bool operator +(Negocio negocio,Cliente cliente)
        {
            if(negocio.Cliente.Count() == 0)
            {
                negocio.Cliente.Enqueue(cliente);
            }
            else
            {
                if(negocio.Cliente.Contains(cliente))
                {
                    return false;
                }
                else
                {
                    negocio.Cliente.Enqueue(cliente);
                    return true;    
                }
            }
            return false;
        }

        public static bool operator ~(Negocio negocio)
        {
            foreach (Cliente item in negocio.Cliente)
            {
                if(negocio.caja.AtenderCliente(item))
                {
                    return true;
                }

            }
            return false;

        }
    }
}
