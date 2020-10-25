using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Torneo<T>
        where T : Equipo
    {
        List<T> equipos = new List<T>();
        private string nombre;

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

        public string JugarPartido()
        {
            int e = new Random().Next(0, equipos.Count);
            int e2 = new Random().Next(0, equipos.Count);
            while(e == e2)
            {
                e2 = new Random().Next(0, equipos.Count);
            }
            return CalcularPartido(this.equipos[e], this.equipos[e2]);
        }
        private Torneo()
        {
            this.equipos = new List<T>();
        }

        public Torneo(string nombre) : this()
        {
            this.Nombre = nombre;
        }

        private string CalcularPartido(T e,T e2)
        {
            int resultado1 = new Random().Next(0, 6);
            int resultado2 = new Random().Next(0, 6);
            while (resultado1 == resultado2)
            {
                resultado2 = new Random().Next(0, 6);
            }
            return $"{e.Nombre} : {resultado1} - {e2.Nombre} : {resultado2}";
        }
        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"Torneo: {this.Nombre.ToUpper()}");
            datos.AppendLine($"Inscriptos: {this.equipos.Count}");
            foreach (Equipo item in this.equipos)
            {
                datos.AppendLine($"{item.Ficha()}");
            }
            return datos.ToString();
        }
        public static bool operator +(Torneo<T> torneo, T equipo)
        {
            bool aux = false;
            if (torneo != equipo)
            {
                torneo.equipos.Add(equipo);
                aux = true;
            }
            return aux;
        }
        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            bool aux = false;
            foreach (Equipo item in torneo.equipos)
            {
                if (item == equipo)
                {
                    aux = true;
                    break;
                }
            }

            return aux;
        }
        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }
    }
}
