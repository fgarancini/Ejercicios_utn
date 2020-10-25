using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum TipoCompetencia
    {
        F1,
        MotoCross
    }
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;
        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
        {
            this.CantidadVueltas = cantidadVueltas;
            this.CantidadCompetidores = cantidadCompetidores;
            this.Tipo = tipo;
        }
        public VehiculoDeCarrera this[int i]
        {
            get
            {
                return this.competidores[i];
            }
        }

        public short CantidadCompetidores
        {
            get { return this.cantidadCompetidores; }
            set { this.cantidadCompetidores = value; }
        }
        public short CantidadVueltas
        {
            get { return this.cantidadVueltas; }
            set { this.cantidadVueltas = value; }
        }
        public List<VehiculoDeCarrera> Competidores
        {
            get
            {
                return this.competidores;
            }
        }
        public TipoCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Cantidad de competidores: {0}\nCantidad de vueltas: {1}", this.cantidadCompetidores, this.cantidadVueltas);
            foreach (VehiculoDeCarrera item in this.Competidores)
            {
                if (item is AutoF1)
                {
                    sb.AppendFormat("\nAutoF1: {0}", ((AutoF1)item).MostrarDatos());
                }
                else if (item is MotoCross)
                {
                    sb.AppendFormat("\nMotoCross: {0}", ((MotoCross)item).MostrarDatos());
                }
            }
            return sb.ToString();
        }

        public static bool operator +(Competencia competencia, VehiculoDeCarrera vehiculo)
        {
            bool aux = false;
            try
            {
                if(competencia != vehiculo)
                {
                    if (competencia.competidores.Count == 0)
                    {
                        if (competencia.tipo == TipoCompetencia.F1 && vehiculo is AutoF1)
                        {
                            Competencia.AgregarCompetidor(competencia, vehiculo);
                            aux = true;
                        }
                        else if(competencia.tipo == TipoCompetencia.MotoCross && vehiculo is MotoCross)
                        {
                            Competencia.AgregarCompetidor(competencia, vehiculo);
                            aux = true;
                        }
                    }
                    else if(competencia.cantidadCompetidores > competencia.competidores.Count)
                    {
                        foreach (VehiculoDeCarrera item in competencia.Competidores)
                        {
                            if (competencia.tipo == TipoCompetencia.F1 && vehiculo is AutoF1)
                            {
                                Competencia.AgregarCompetidor(competencia, vehiculo);
                                aux = true;
                                break;
                            }
                            else if(competencia.tipo == TipoCompetencia.MotoCross && vehiculo is MotoCross)
                            {
                                Competencia.AgregarCompetidor(competencia, vehiculo);
                                aux = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", competencia.GetType().ToString(), "Suma");
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
           
            return aux;
        }
        private static void AgregarCompetidor(Competencia competencia,VehiculoDeCarrera vehiculo)
        {
            Random random = new Random();
            competencia.competidores.Add(vehiculo);
            vehiculo.EnCompetencia = true;
            vehiculo.VueltasRestantes = competencia.cantidadVueltas;
            vehiculo.CantidadDeCombustibles = (short)random.Next(15, 100);
        }
        public static bool operator -(Competencia competencia, VehiculoDeCarrera vehiculo)
        {
            bool aux = false;
            foreach (VehiculoDeCarrera item in competencia.Competidores)
            {
                if (item == vehiculo)
                {
                    competencia.competidores.Remove(vehiculo);
                    //vehiculo.EnCompetencia = false;
                    //vehiculo.VueltasRestantes = 0;
                    //vehiculo.CantidadDeCombustibles = 0;
                    aux = true;
                    break;
                }
            }
            return aux;
        }
        public static bool operator ==(Competencia competencia, VehiculoDeCarrera vehiculo)
        {
            bool aux = false;
            
            foreach (VehiculoDeCarrera item in competencia.competidores)
            {
                if (item is AutoF1 && vehiculo is AutoF1)
                {
                    aux = true;
                    break;
                }
                else if (item is MotoCross && vehiculo is AutoF1)
                {
                    aux = true;
                    break;
                }
            }
            if (!aux)
            {
                throw new CompetenciaNoDisponibleException("Vehículo no en competencia", typeof(Competencia).ToString(), "Metodo ==", new Exception());
            }
            return aux;
        }

        public static bool operator !=(Competencia competencia, VehiculoDeCarrera vehiculo)
        {
            return !(competencia == vehiculo);
        }
    }
}
