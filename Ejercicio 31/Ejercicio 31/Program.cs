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

            PuestoAtencion caja = new PuestoAtencion(0); 
            Negocio makro = new Negocio("Makro");

            Cliente cliente1 = new Cliente(1,"sergei");
            Cliente cliente2 = new Cliente(2,"Kamila");
            Cliente cliente3 = new Cliente(3,"Maximo");
            bool test = makro + cliente1;
            test = makro + cliente2;
            test = makro + cliente3;
            Console.WriteLine(makro.Cliente.Nombre);

            caja.AtenderCliente(cliente1);
            Console.WriteLine(makro.Cliente.Nombre);
            caja.AtenderCliente(cliente2);
            Console.WriteLine(makro.Cliente.Nombre);
            caja.AtenderCliente(cliente3);





            Console.ReadKey();
        }
    }
}
