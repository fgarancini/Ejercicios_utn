using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_07
{
    public class Jugador : Persona
    {
        
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        public Jugador(int dni,string nombre, int totalGoles, int totalPartidos) :base(dni,nombre)
        {
            this.partidosJugados = totalPartidos;
            this.totalGoles = totalGoles;
        }

        public Jugador(int dni, string nombre) : base(dni, nombre)
        {

        }

        #region propiedadesSoloLectura
        public float PromedioGoles
        {
            get
            {
                promedioGoles = (float)totalGoles / partidosJugados;
                return promedioGoles;
            }
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

        public string MostrarDatos()
        {
            return $"Nombre: {this.Nombre}, DNI: {this.Dni} || Partidos Jugados: {this.partidosJugados} || Promedio de Goles: {this.PromedioGoles} || Goles totales: {this.totalGoles}. ";
        }

        public static bool operator ==(Jugador jugador1, Jugador jugador2)
        {
            return jugador1.Dni == jugador2.Dni;
        }

        public static bool operator !=(Jugador jugador1, Jugador jugador2)
        {
            return !(jugador1 == jugador2);
        }
    }
}
