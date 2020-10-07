using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jardin
    {
        public enum Tipo { Terrozo, Arenozo }
        private int espacioTotal;
        private List<Planta> plantas;
        private static Tipo tipo;
        static Jardin()
        {
            tipo = Tipo.Terrozo;
        }

        private Jardin()
        {
            this.plantas = new List<Planta>();
        }
      
        public Jardin(int espacioTotal) : this()
        {
            this.espacioTotal = espacioTotal;
        }
        public Tipo TipoSuelo
        {
            set { tipo = value; }
        }

        private int EspacioOcupado()
        {
            int acumulador=0;
            foreach (Planta planta in this.plantas)
            {
                acumulador = acumulador + planta.Tamanio;
            }
            return acumulador;
        }

        private int EspacioOcupado(Planta planta)
        {
            int acumulador = this.EspacioOcupado();
            return acumulador + planta.Tamanio;
        }

        public static bool operator +(Jardin jardin, Planta planta)
        {
            if(jardin.espacioTotal >= jardin.EspacioOcupado(planta))
            {
                jardin.plantas.Add(planta);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Composición del jardin: {Jardin.tipo}");
            sb.AppendLine($"Espacio ocupado: {this.EspacioOcupado()} de {this.espacioTotal}");
            sb.AppendLine("LISTA DE PLANTAS");
            foreach (Planta planta in this.plantas)
            {
                sb.AppendLine (planta.ResumenDeDatos());
                sb.AppendLine("-------------------------------------------");
            }
            return sb.ToString();
        }
    }
}
