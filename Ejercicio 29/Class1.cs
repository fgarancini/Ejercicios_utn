using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_07
{

    public class Equipo
    {
        private static short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

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

        public List<Jugador> Jugadores
        {
            get { return this.jugadores; }
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

    
}
