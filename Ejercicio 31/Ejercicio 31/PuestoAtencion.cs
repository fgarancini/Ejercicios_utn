using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    
    class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1,
            Caja2
        }
        private static int numeroActual;
        Puesto puesto;
        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto) :this()
        {
            this.puesto = puesto;
        }
        private static int NumeroActual
        {
            get 
            {
                numeroActual++;
                return numeroActual; 
            }  

        }

        public bool AtenderCliente(Cliente cliente)
        {
            System.Threading.Thread.Sleep(5000);
            return true;
        }

    }
}
