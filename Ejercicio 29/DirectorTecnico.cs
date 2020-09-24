using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_07
{
    class DirectorTecnico : Persona
    {
        private DateTime fechaDeNacimiento;

        private DirectorTecnico(string nombre) : base (nombre)
        {

        }

        public DirectorTecnico(string nombre, DateTime fechaDeNacimiento) : base(nombre)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public string MostrarDatos()
        {
            return $"Nombre {this.Nombre} , Fecha de Nacimiento: {this.fechaDeNacimiento.ToShortDateString()} ";
        }

        public static bool operator ==(DirectorTecnico directorTecnico1, DirectorTecnico directorTecnico2)
        {
            return directorTecnico1.Nombre == directorTecnico2.Nombre && directorTecnico1.fechaDeNacimiento == directorTecnico2.fechaDeNacimiento;
        }

        public static bool operator !=(DirectorTecnico directorTecnico1,DirectorTecnico directorTecnico2)
        {
            return !(directorTecnico1 == directorTecnico2);
        }
    }
}
