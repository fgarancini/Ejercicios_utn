using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;
        public VehiculoDeCarrera(short numero, string escuderia)
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

        public static bool operator ==(VehiculoDeCarrera vehiculoDeCarrera1, VehiculoDeCarrera vehiculoDeCarrera2)
        {
            return (vehiculoDeCarrera1.numero == vehiculoDeCarrera2.numero && vehiculoDeCarrera1.escuderia == vehiculoDeCarrera2.escuderia);
        }
        public static bool operator !=(VehiculoDeCarrera vehiculoDeCarrera1, VehiculoDeCarrera vehiculoDeCarrera2)
        {
            return !(vehiculoDeCarrera1== vehiculoDeCarrera2);
        }
        public virtual string MostrarDatos()
        {
            return $"Numero: {this.numero}, Escuderia: {this.escuderia} || Cantidad de combustible: {this.cantidadCombustible} || Vueltas restantes: {this.vueltasRestantes}";
        }
    }
}
