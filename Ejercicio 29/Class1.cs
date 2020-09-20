using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_07
{

    public class Equipo
    {
        public static short cantidadDeJugadores;
        public List<Jugador> jugadores;
        public string nombre;

        /// <summary>
        /// Constructor privado de la lista
        /// </summary>
        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad, string nombre) : this()
        {
            Equipo.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }
        /// <summary>
        /// Agrega un jugador si la lista esta vacia, recorre la lista para 
        /// comprobar que el jugador no este en la lista, si no lo esta lo agrega
        /// </summary>
        /// <param name="equipo"></param>
        /// <param name="jugador"></param>
        /// <returns></returns>
        public static bool operator +(Equipo equipo, Jugador jugador)
        {
            if (equipo.jugadores.Count == 0)
            {
                equipo.jugadores.Add(jugador);
            }
            else
            {
                foreach (Jugador item in equipo.jugadores)
                {
                    if (item == jugador)
                    {
                        return false;
                    }
                    equipo.jugadores.Add(jugador);
                    return true;
                }
            }
            return false;
        }
    }

    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.Dni = 0;
            this.nombre = "";
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre) :this()
        {
            this.Dni = dni;
            this.Nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) :this(dni,nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
            this.promedioGoles =(float) this.totalGoles / this.partidosJugados;
        }

        #region propiedadesSoloLectura
        public float PromedioGoles
        {
            get { return this.promedioGoles; }
        }

        public int PartidosJugados
        {
            get { return this.partidosJugados; }
        }

        public int TotalGoles
        {
            get { return this.totalGoles; }
        }
        #endregion


        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }


        public string MostrarDatos()
        {
            return $"Nombre: {this.nombre}, DNI: {this.dni} || Partidos Jugados: {this.partidosJugados} || Promedio de Goles: {this.promedioGoles} || Goles totales: {this.totalGoles}. ";
        }

        public static bool operator ==(Jugador jugador1,Jugador jugador2)
        {
            return jugador1.dni == jugador2.dni;
        }

        public static bool operator !=(Jugador jugador1,Jugador jugador2)
        {
            return !(jugador1 == jugador2);
        }
    }
}
