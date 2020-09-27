using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        public enum Franja{ Franja_1, Franja_2,Franja_3}

        private protected Franja franjaHoraria;


        public Provincial(Franja miFranja ,Llamada llamada) : base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(float duracion, Franja miFranja, string nroDestino, string nroOrigen) : this(miFranja, new Llamada(duracion, nroDestino, nroOrigen))
        {

        }

        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        private float CalcularCosto()
        {
            if (this.franjaHoraria == Franja.Franja_1)
            {
                return this.duracion * 0.99f;
            }
            if (this.franjaHoraria == Franja.Franja_2)
            {
                return this.duracion * 1.25f;
            }
            return this.duracion * 0.66f;
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
