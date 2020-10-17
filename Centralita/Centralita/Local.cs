using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;
        public float Costo
        {
            get
            {
                return this.costo;
            }
        }
        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
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
            return this.costo * this.duracion;
        }

        protected override string Mostrar()
        {
            StringBuilder datosLocal = new StringBuilder();

            datosLocal.AppendLine("LLAMADA LOCAL");
            datosLocal.Append(base.Mostrar() +"\n");
            datosLocal.Append($"Costo por minuto: {this.Costo}\n");
            datosLocal.AppendLine("Costo de la llamada:" + this.CostoLlamada);

            return datosLocal.ToString();
        }

        public override string ToString()
        {
            return Mostrar();
        }
        public override bool Equals(Object obj)
        {
            return (obj is Local);       
        }
    }
}
