using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        #region Constructores
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa) :this()
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion

        #region Propiedades
        public List<Llamada> ListaDeLlamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        #endregion

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            listaDeLlamadas.Add(nuevaLlamada);
        }
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float total = 0;

            foreach (Llamada item in this.listaDeLlamadas)
            {
                switch(tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if(item is Local)
                        {
                            total += ((Local)item).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if(item is Provincial)
                        {
                            total += ((Provincial)item).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:
                        if(item is Local)
                        {
                            total += ((Local)item).CostoLlamada;
                        }
                        else if(item is Provincial)
                        {
                            total += ((Provincial)item).CostoLlamada;
                        }
                        break;
                }
            }
            return total;
        }

        public void OrdenarLlamadas()
        {
            this.ListaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($"Nombre empresa: {this.razonSocial}");
            datos.AppendLine($"Ganancia total: {this.GananciasPorTotal}");
            datos.AppendLine($"Ganancias Provinciales: {this.GananciasPorProvincial} || Ganancias Locales: {this.GananciasPorLocal}");
                datos.AppendLine($"\nDetalle");
            foreach (Llamada item in listaDeLlamadas)
            {
                datos.AppendLine($"{item.ToString()}");
            }

            return datos.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public static bool operator ==(Centralita centralita,Llamada llamada)
        {
            bool aux = false;
            foreach (Llamada item in centralita.listaDeLlamadas)
            {
                if (item == llamada)
                {
                    aux = true;
                }
            }
            return aux;
        }
        public static bool operator !=(Centralita centralita, Llamada llamada)
        {
            return !(centralita == llamada);
        }

        public static Centralita operator +(Centralita centralita,Llamada nuevaLlamada)
        {
            try
            {
                if (centralita != nuevaLlamada)
                {
                    centralita.AgregarLlamada(nuevaLlamada);
                }
                else
                {
                    throw new CentralitaException("Ya se encuentra registrada esta llamada", $"{centralita.GetType()}", $"Metodo Agregar llamada");
                }
            }
            catch(CentralitaException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return centralita;
        }
    }
}
