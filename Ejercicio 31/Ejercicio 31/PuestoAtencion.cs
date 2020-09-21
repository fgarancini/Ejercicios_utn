using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    
    public class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1,
            Caja2
        }
        private static int numeroActual;

        private Puesto puesto;
        private PuestoAtencion()
        {
            NumeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto) :this()
        {
            this.puesto = puesto;
        }
        private static int NumeroActual
        {
            get 
            {
                return numeroActual; 
            }  
            set
            {
                numeroActual++;
            }
        }

        public bool AtenderCliente(Cliente cliente)
        {
            System.Threading.Thread.Sleep(5000);
            return true;
        }

    }
}
