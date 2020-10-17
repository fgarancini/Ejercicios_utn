using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita c = new Centralita("Fede Center");

            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f); 
            Provincial l2 = new Provincial("Morón", Franja.Franja_1, 21, "Bernal"); 
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f); 
            Provincial l4 = new Provincial(Franja.Franja_3, l2);

            c += l1;
            c += l2;
            c += l3;
            c += l4;

            Console.WriteLine(c.ToString()); 
            
            Console.ReadKey();
        }
    }
}
