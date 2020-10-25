using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> CopaSudamericana = new Torneo<EquipoFutbol>("Copa Sudamericana");
            Torneo<EquipoBasquet> FIBA = new Torneo<EquipoBasquet>("FIBA");

            EquipoFutbol river = new EquipoFutbol("River",new DateTime(1901,05,25));
            EquipoFutbol boca = new EquipoFutbol("Boca", new DateTime(1905, 03, 3));
            EquipoFutbol independiente = new EquipoFutbol("Independiente", new DateTime(1905, 01, 1));
            EquipoFutbol racing = new EquipoFutbol("Racing", new DateTime(1903, 04, 25));

            _ = CopaSudamericana + river;
            _ = CopaSudamericana + boca;
            _ = CopaSudamericana + independiente;
            _ = CopaSudamericana + racing;

            Console.WriteLine(CopaSudamericana.Mostrar());
            Console.WriteLine(CopaSudamericana.JugarPartido());
            Console.WriteLine(CopaSudamericana.JugarPartido());
            Console.WriteLine(CopaSudamericana.JugarPartido());
            Console.WriteLine(CopaSudamericana.JugarPartido());

            Console.ReadKey();

            EquipoBasquet equipoBasquet1 = new EquipoBasquet("Boca", new DateTime(1920, 10, 10));
            EquipoBasquet equipoBasquet2 = new EquipoBasquet("Atlas", new DateTime(1920, 10, 10));
            EquipoBasquet equipoBasquet3 = new EquipoBasquet("Gimnasia", new DateTime(1920, 10, 10));
            EquipoBasquet equipoBasquet4 = new EquipoBasquet("Independiente", new DateTime(1920, 10, 10));

            _ = FIBA + equipoBasquet1;
            _ = FIBA + equipoBasquet2;
            _ = FIBA + equipoBasquet3;
            _ = FIBA + equipoBasquet4;

            Console.WriteLine(FIBA.Mostrar());
            Console.WriteLine(FIBA.JugarPartido());
            Console.WriteLine(FIBA.JugarPartido());
            Console.WriteLine(FIBA.JugarPartido());
            Console.WriteLine(FIBA.JugarPartido());

            Console.ReadKey();


        }
    }
}
