using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        private protected float costo;

        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(string origen, float duracion, string destino, float costo) : this(new Llamada(duracion, destino, origen), costo)
        {

        }

        public float CalcularCosto()
        {
            return costo * duracion;
        }

        public new string Mostrar()
        {

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(String.Format("La duracion es: {0}", this.Duracion));
            stringBuilder.AppendLine(String.Format("El numero de origen es: {0}", this.NroOrigen));
            stringBuilder.AppendLine(String.Format("La numero de destino es: {0}", this.NroDestino));
            stringBuilder.AppendLine(String.Format("El costo de llamada es: {0}", this.CostoLlamada));

            return stringBuilder.ToString();
        }

    }
}
