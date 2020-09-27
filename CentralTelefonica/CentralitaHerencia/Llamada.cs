using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public enum TipoLlamada { Local,Provincial,Todas}
    public class Llamada
    {
        private protected float duracion;

        private protected string nroDestino;

        private protected string nroOrigen;

        public string NroOrigen
        {
            get { return nroOrigen; }
        }


        public string NroDestino
        {
            get { return nroDestino; }
        }

        public float Duracion
        {
            get { return duracion; }
        }

        public Llamada(float duracion,string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(String.Format("La duracion es: {0}", this.Duracion));
            stringBuilder.AppendLine(String.Format("El numero de origen es: {0}", this.NroOrigen));
            stringBuilder.AppendLine(String.Format("La numero de destino es: {0}", this.NroDestino));

            return stringBuilder.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1,Llamada llamada2)
        {
            int criterio = 0;
            if(llamada1.Duracion < llamada2.Duracion)
            {
                criterio = -1;
            }else if(llamada1.Duracion > llamada2.Duracion)
            {
                criterio = 1;
            }
            return criterio;
        }
    }
}
