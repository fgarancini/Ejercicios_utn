using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        public enum TipoLlamada 
        {
            Local,
            Provincial,
            Todas
        }
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion 
        {
            get
            {
                return this.duracion;
            }    
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        public abstract float CostoLlamada { get; }
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if(llamada1.Duracion > llamada2.Duracion)
            {
                return 1;
            }
            else if(llamada1.Duracion < llamada2.Duracion)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        protected virtual string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat($"Duracion: {this.Duracion}\nNumero de Destino: {this.NroDestino}\nNumero de Origen: {this.NroOrigen}");

            return datos.ToString();
        }
        
        public static bool operator ==(Llamada llamada_1,Llamada llamada_2)
        {
            if (llamada_1.NroDestino==llamada_2.NroDestino && llamada_1.NroOrigen == llamada_2.NroOrigen)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Llamada llamada_1, Llamada llamada_2)
        {
            return !(llamada_1 == llamada_2);
        }
    }
}
