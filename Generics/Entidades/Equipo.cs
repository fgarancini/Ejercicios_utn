using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public Equipo(string nombre, DateTime dateTime)
        {
            this.Nombre = nombre;
            this.fechaCreacion = dateTime;
        }

        public static bool operator ==(Equipo equipo,Equipo equipo1)
        {
            return (equipo.nombre == equipo1.nombre && equipo.fechaCreacion == equipo1.fechaCreacion);
        }
        public static bool operator !=(Equipo equipo, Equipo equipo1)
        {
            return !(equipo == equipo1);
        }

        public string Ficha()
        {
            return $"{this.nombre} fundado el {this.fechaCreacion}";
        }
    }
}