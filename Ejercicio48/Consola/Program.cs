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
            Recibo recibo1 = new Recibo();
            Recibo recibo2 = new Recibo(55);
            Factura factura1 = new Factura(099954);
            Factura factura2 = new Factura(099954);

            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();

            _ = contabilidad + recibo1;
            _ = contabilidad + recibo2;
            _ = contabilidad + factura1;
            _ = contabilidad + factura2;

            foreach (Documento item in contabilidad.Ingresos)
            {
                Console.WriteLine(item.Numero);
            }
            foreach (Documento item in contabilidad.Egresos)
            {
                Console.WriteLine(item.Numero);
            }

            Console.ReadKey();
        }
    }
}
