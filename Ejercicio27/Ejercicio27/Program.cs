using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> miLista = new List<int>();
            Stack<int> negativos = new Stack<int>();
            Queue<int> positivos = new Queue<int>();
            string aux;
            int cant = 0;
            do
            {
                Console.WriteLine("Introduzca un numero:");
                aux = Console.ReadLine();
                miLista.Add(Int32.Parse(aux));
                cant++;

            } while (cant != 5);

            miLista.Sort(Ordenar);

            foreach (int item in miLista)
            {
                if (item < 0)
                {
                    negativos.Push(item);
                }
                else
                {
                    positivos.Enqueue(item);
                }
            }


            Console.WriteLine("Negativos");
            foreach (int pos in negativos)
            {
                Console.WriteLine(pos);
            }
            Console.WriteLine("Positivos");

            foreach (int item in positivos)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
        public static int Ordenar(int numeroAnterior, int numeroSiguente)
        {
            int criterio = 0;
            if (numeroAnterior < numeroSiguente)
            {
                criterio = -1;
            }
            else if (numeroAnterior > numeroSiguente)
            {
                criterio = 1;
            }

            return criterio;
        }
    }
    }
}
