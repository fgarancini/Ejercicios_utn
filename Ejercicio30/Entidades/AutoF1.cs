using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;
        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
        }

        public short CantidadDeCombustibles
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }

        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }
        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }



        public string MostrarDatos()
        {
            return $"Numero: {this.numero}, Escuderia: {this.escuderia} || Cantidad de combustible: {this.cantidadCombustible} || Vueltas restantes: {this.vueltasRestantes}";
        }
        
        public static bool operator ==(AutoF1 auto1, AutoF1 auto2)
        {
            return (auto1.numero == auto2.numero && auto1.escuderia == auto2.escuderia);
        }
        public static bool operator !=(AutoF1 auto1, AutoF1 auto2)
        {
            return !(auto1 == auto2);
        }
        

    }

}
