using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    [Serializable]
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;
        public string NombreClase
        {
            get
            {
                return this.nombreClase;
            }
        }
        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }
        public CompetenciaNoDisponibleException(string message, string clase, string metodo, Exception inner) : base(message, inner) 
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
        public CompetenciaNoDisponibleException(string message,string clase,string metodo) : this(message, clase, metodo, null)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public override string ToString()
        {
            StringBuilder exceptMessage = new StringBuilder();

            exceptMessage.AppendLine($"Excepcion en el metodo: {this.NombreMetodo}, de clase: {this.NombreClase}");
            exceptMessage.AppendLine($"{this.Message}");
            exceptMessage.AppendLine($"{this.InnerException}\t");

            return exceptMessage.ToString();
        }
    }
}
