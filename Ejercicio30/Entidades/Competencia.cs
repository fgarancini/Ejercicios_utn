using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Cantidad de competidores: {0}\nCantidad de vueltas: {1}", this.cantidadCompetidores, this.cantidadVueltas);
            foreach (AutoF1 a in this.competidores)
            {
                sb.AppendFormat("\nAutoF1: {0}", a.MostrarDatos());
            }
            return sb.ToString();
        }

        public static bool operator +(Competencia competencia, AutoF1 auto)
        {
            Random random = new Random();

            if (competencia.competidores.Count() < 5 && competencia == auto)
            {
                competencia.competidores.Add(auto);
                auto.EnCompetencia = true;
                auto.VueltasRestantes = competencia.cantidadVueltas;
                auto.CantidadDeCombustibles =(short)random.Next(15, 100);
                return true;
            }
            return false;
        }
        public static bool operator -(Competencia competencia, AutoF1 auto)
        {
            return !(competencia == auto);
        }
        public static bool operator ==(Competencia competencia, AutoF1 auto)
        {
            foreach (AutoF1 b in competencia.competidores)
            {
                if (b == auto)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Competencia competencia, AutoF1 auto)
        {
            return !(competencia == auto);
        }
    }
}
