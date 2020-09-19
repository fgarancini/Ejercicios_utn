using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo rica = new Equipo(11,"River");
            Jugador Romero = new Jugador(2854, "Romero", 0, 23);
            Jugador Romero_2 = new Jugador(2864, "Romero", 0, 23);
            Jugador MarcosRojo = new Jugador(234114, "Marcos Rojo", 17, 45);
            Console.WriteLine(Romero.MostrarDatos());
            if(Romero == Romero_2)
            {
                Console.WriteLine("Son la misma persona");
            }
            else
            {
                Console.WriteLine("No la misma persona");
            }

            Console.WriteLine($"{MarcosRojo.MostrarDatos()}");
            

            Console.ReadKey();
        }
    }
}
