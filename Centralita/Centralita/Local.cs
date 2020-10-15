using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Local : Llamada
    {
        protected float costo;

        public override float CostoLlamada
        {
            get
            {
                return this.costo;
            }
        }

        public Local(Llamada llamada,float costo) 
        :base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen,float duracion,string destino, float costo) :base(duracion,destino,origen)
        {
            this.costo = costo;
        }

        private float CalcularCosto()
        {
            return (float)base.Duracion * this.CostoLlamada;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LLAMADA LOCAL");
            sb.Append(base.Mostrar() +"\n");
            sb.AppendLine("Costo:" + this.CostoLlamada);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        public override bool Equals(Object obj)
        {
            bool aux = false;

            if (obj is Local)
            {
                aux = true;
            }

            return aux;
        }
    }
}
