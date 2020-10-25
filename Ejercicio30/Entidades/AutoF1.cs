using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;
        public short CaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                this.caballosDeFuerza = value;
            }
        }
        public AutoF1(short numero, string escuderia,short caballosDeFuerza) : base(numero, escuderia)
        { 
            this.CaballosDeFuerza = caballosDeFuerza;
        }
        public AutoF1(short numero,string escuderia) :this(numero,escuderia,0)
        {

        }
        public override string MostrarDatos()
        {
            StringBuilder datosF1 = new StringBuilder();
            datosF1.AppendLine("Formula 1");
            datosF1.AppendLine($"{base.MostrarDatos()}");
            datosF1.AppendLine($"Caballos de fuerza: {this.caballosDeFuerza}");
            return datosF1.ToString();
        }
        public static bool operator ==(AutoF1 auto1, AutoF1 auto2)
        {
            return (VehiculoDeCarrera)auto1 == (VehiculoDeCarrera)auto2 && auto1.caballosDeFuerza == auto2.caballosDeFuerza;
        }
        public static bool operator !=(AutoF1 auto1, AutoF1 auto2)
        {
            return !(auto1 == auto2);
        }
        

    }

}
