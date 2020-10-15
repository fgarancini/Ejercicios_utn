using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rosal : Planta
    {
        public enum Color { Roja,Blanca,Amarilla,Rosa,Azul}

        private Color florColor;

        public Rosal(string nombre, int tamanio) : base(nombre, tamanio)
        {
            this.florColor = Color.Rosa;
        }
        
        public Rosal(string nombre,int tamanio, Color color) : this(nombre, tamanio)
        {
            this.florColor = color;
        }
        public override bool TieneFlores
        {
            get { return true; }
        }

        public override bool TieneFrutos
        {
            get { return false; }
        }

        public override string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.ResumenDeDatos());
            sb.AppendLine($"Flores de color: {this.florColor}");
            return sb.ToString();
        }
    }
}
