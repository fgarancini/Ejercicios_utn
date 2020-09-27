using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        

        private string razonSocial;

        private List<Llamada> listaDeLlamadas;

        public Centralita() 
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        public List<Llamada> ListaDeLlamadas
        {
            get { return this.listaDeLlamadas; }
        }

        public float GananciasPorLocal
        {
            get { return this.CalcularGanancia(TipoLlamada.Local); }
        }

        public float GananciasPorProvincial
        {
            get { return this.CalcularGanancia(TipoLlamada.Provincial); }
        }

        public float GananciasPorTotal
        {
            get { return this.CalcularGanancia(TipoLlamada.Todas); }
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float acumulador = 0;
            foreach (Llamada llamada in ListaDeLlamadas)
            {
                switch (tipo)
                {
                    case TipoLlamada.Local:
                        if(llamada is Local)
                        {
                            acumulador = acumulador + ((Local)llamada).CostoLlamada;
                        }
                        break;

                    case TipoLlamada.Provincial:
                        if(llamada is Provincial)
                        {
                            acumulador = acumulador + ((Provincial)llamada).CostoLlamada;
                        }
                        break;
                    case TipoLlamada.Todas:
                        if (llamada is Local)
                        {
                            acumulador = acumulador + ((Local)llamada).CostoLlamada;
                        }
                        if (llamada is Provincial)
                        {
                            acumulador = acumulador + ((Provincial)llamada).CostoLlamada;
                        }
                        break;
                }
                
            }
            return acumulador;
        }

        public string Mostrar()
        {
            StringBuilder llamada = new StringBuilder();
            llamada.AppendFormat("Razon social:{0},Ganancia Total: {1},Ganancia Local: {2}, Ganancia provincial: {3} ", this.razonSocial, this.CalcularGanancia(TipoLlamada.Todas), this.CalcularGanancia(TipoLlamada.Local), this.CalcularGanancia(TipoLlamada.Provincial));
            llamada.AppendLine("\n");

            foreach (Llamada unaLlamada in ListaDeLlamadas)
            {
                llamada.AppendLine(unaLlamada.Mostrar() + "\n");

            }
            return llamada.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.ListaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
            Console.WriteLine("-------------------------------------- \n ******ORDENADA**********");
        }

    }
}
