using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_38
{
    public abstract class Sobreescrito
    {
        protected string miAtributo;

        public Sobreescrito()
        {
            this.miAtributo = "Probar abstractos";
        }

        public abstract string MiPropiedad 
        {
            get;
        }

        public abstract string MiMetodo();
        public string ToString()
        {
            return "¡Este es mi método ToString sobreescrito!";
        }

        public bool Equals(Sobreescrito sobreescrito,Sobreescrito sobreescrito2)
        {
            if(sobreescrito is Sobreescrito && sobreescrito2 is Sobreescrito)
            {
                return true;
            }
            return false;
            
        }

        public int GetHashCode()
        {
            return 1142510187;
        }
    }
}
