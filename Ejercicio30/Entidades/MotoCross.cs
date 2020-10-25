using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public short Cilindrada
        {
            get { return this.cilindrada; }
            set { this.cilindrada = value; }
        }

        public MotoCross(short numero,string escuderia) :base(numero,escuderia)
        {

        }
        public MotoCross(short numero, string escuderia,short cilindrada) : base(numero, escuderia)
        {
            this.Cilindrada = cilindrada;
        }

        public override string MostrarDatos()
        {
            StringBuilder datosMotocross = new StringBuilder();
            datosMotocross.AppendLine("MotoCross");
            datosMotocross.AppendLine($"{base.MostrarDatos()}");
            datosMotocross.AppendLine($"Cilindrada: {this.Cilindrada}");
            return datosMotocross.ToString();
        }

        public static bool operator ==(MotoCross moto1,MotoCross moto2)
        {
            return (VehiculoDeCarrera)moto1 == (VehiculoDeCarrera)moto2 && moto1.Cilindrada == moto2.Cilindrada;
        }

        public static bool operator !=(MotoCross moto1, MotoCross moto2)
        {
            return !(moto1 == moto2);
        }
    }
}
