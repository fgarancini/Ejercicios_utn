using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Planta
    {
        private string nombre;
        private int tamanio;


        public int Tamanio
        {
            get { return this.tamanio; }
        }
        public abstract bool TieneFlores { get; }

        public abstract bool TieneFrutos { get; }

        public Planta(string nombre, int tamanio)
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
        }
         public virtual string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.nombre} tiene un tamanio de {this.tamanio}\r\n");
            if(TieneFlores == true)
                sb.AppendLine($"Tiene flores");
            if(TieneFrutos == true)
                sb.AppendLine($"Tiene fruto");

            return sb.ToString();
        }
        

    }
}
