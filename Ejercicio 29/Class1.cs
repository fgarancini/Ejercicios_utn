using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_07
{
    class Equipo
    {
        private short cantidadDeJugadores;
        private static List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad, string nombre) : this()
        {
            CantidadJugadores = cantidad;
            this.nombre = nombre;
        }


        public short CantidadJugadores
        {
            get { return cantidadDeJugadores; }
            set { this.cantidadDeJugadores = value; }
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            if(jugadores.Contains(j) == false && jugadores.Count() < e.cantidadDeJugadores)
            {
                jugadores.Add(j);
                return true;
            }
            return false;

        }


    }

    class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.dni = 0;
            this.nombre = "";
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre) :this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) :this(dni,nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
            this.PromedioGoles =(float) totalPartidos / totalGoles;
        }


        public float PromedioGoles
        {
            get { return promedioGoles; }
            set { this.promedioGoles = value; }
        }

        public string MostrarDatos()
        {
            return $"Nombre: {this.nombre}, DNI: {this.dni} || Partidos Jugados: {this.PromedioGoles} || Promedio de Goles: {this.promedioGoles} || Goles totales: {this.totalGoles}. ";
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
