using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Arbusto : Planta
    {
        public Arbusto(string nombre, int tamanio) : base(nombre, tamanio)
        {

        }

        public override bool TieneFlores
        {
            get { return false; }
        }

        public override bool TieneFrutos
        {
            get { return false; }
        }

        public override string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.ResumenDeDatos());

            return sb.ToString();
        }

    }
}
