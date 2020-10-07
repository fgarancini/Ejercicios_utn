using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Banano : Planta
    {
        private string codigo;

        public Banano(string nombre, int tamanio, string codigo) : base(nombre,tamanio)
        {
            this.codigo = codigo;
        }

        public override bool TieneFlores
        {
            get { return false; }
        }

        public override bool TieneFrutos
        {
            get { return true; }
        }

        public override string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.ResumenDeDatos());
            sb.AppendFormat($"Codigo internacional: {this.codigo}");
            return sb.ToString();
        }
    }
}
