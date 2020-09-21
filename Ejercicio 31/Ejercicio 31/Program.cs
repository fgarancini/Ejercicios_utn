using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    class Program
    {
        static void Main(string[] args)
        {

            Negocio makro = new Negocio("Makro");
            Cliente cliente1 = new Cliente(1,"sergei");
            Cliente cliente2 = new Cliente(1,"Kamila");
            Cliente cliente3 = new Cliente(1,"Maximo");

            bool test = makro + cliente1;
            test = makro + cliente2;
            test = makro + cliente3;

            foreach (Cliente item in makro.Cliente)
            {
                Console.WriteLine(makro.Cliente.Count);
                Console.WriteLine(item.Nombre);
            }
            Console.ReadKey();
        }
    }
}
