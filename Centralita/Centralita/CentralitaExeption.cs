using System;
using System.Runtime.Serialization;

namespace CentralitaHerencia
{
    [Serializable]
    internal class CentralitaException : Exception
    {
        //Atributos
        private string nombreClase;
        private string nombreMetodo;
        //Propiedades
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

        public CentralitaException(string mensaje, string clase, string metodo) : base(mensaje)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException) : base(mensaje, innerException)
        {
            
        }
    }
}