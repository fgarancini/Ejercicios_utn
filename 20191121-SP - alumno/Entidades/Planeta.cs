using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void InformacionDeAvance(object sender, PlanetaEventArgs e);
    [Serializable]
    public class Planeta
    {
        public event InformacionDeAvance InformarAvance;
        private short velocidadTraslacion;
        private short posicionActual;
        private short radioRespectoSol;
        private object objetoAsociado;
        public Planeta()
        {

        }
        public Planeta(short velocidad, short posicion, short radioRespectoSol, object objetoVisual)
        {
            this.VelocidadTraslacion = velocidad;
            this.PosicionActual = posicion;
            this.objetoAsociado = objetoVisual;
            this.RadioRespectoSol = radioRespectoSol;
        }

        /// <summary>
        /// PictureBox u objeto gráfico asociado al planeta.
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public object ObjetoAsociado
        {
            get
            {
                return this.objetoAsociado;
            }
            set
            {
                this.objetoAsociado = value;
            }
        }

        public short PosicionActual
        {
            get
            {
                return this.posicionActual;
            }

            set
            {
                this.posicionActual = value;
            }
        }

        public short RadioRespectoSol
        {
            get
            {
                return this.radioRespectoSol;
            }

            set
            {
                this.radioRespectoSol = value;
            }
        }

        public short VelocidadTraslacion
        {
            get
            {
                return this.velocidadTraslacion;
            }

            set
            {
                this.velocidadTraslacion = value;
            }
        }

        /// <summary>
        /// Avance del planeta según su velocidad
        /// </summary>
        public short Avanzar()
        {
            this.PosicionActual += VelocidadTraslacion;
            return this.PosicionActual;
        }

        /// <summary>
        /// Simulación del movimiento del planeta
        /// </summary>
        public void AnimarSistemaSolar()
        {
            do
            {
                System.Threading.Thread.Sleep(60 + this.VelocidadTraslacion);
                if (this.InformarAvance != null)
                {
                    this.InformarAvance.Invoke(this,new PlanetaEventArgs(Avanzar(),radioRespectoSol));
                }
            } while (true);
        }
    }
}
