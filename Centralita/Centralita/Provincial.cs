using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1 = 99,
            Franja_2 = 125,
            Franja_3 = 66
        }

        protected Franja franjaHoraria;

        public Provincial(Franja franja, Llamada llamada) :this(llamada.NroOrigen, franja, llamada.Duracion,llamada.NroDestino)
        {

        }

        public Provincial(string origen, Franja franja, float duracion, string destino) : base(duracion,destino,origen)
        {
            this.franjaHoraria = franja;
        }
        public override float CostoLlamada 
        { 
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            return (((float)this.franjaHoraria / 100)) * base.Duracion;
        }

        protected override string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($"Franja: {this.franjaHoraria}");
            datos.AppendLine($"Duracion: {base.Duracion} || Numero de Origen: {base.NroOrigen} || Numero de Destino: {base.NroDestino}");
            datos.AppendLine($"Costo total de la llamada {this.CostoLlamada}");
            datos.AppendLine($"Franja Horaria {this.franjaHoraria}");
            return datos.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(Object obj)
        {
            bool aux = false;

            if (obj is Provincial)
            {
                aux = true;
            }

            return aux;
        }
    }
}
