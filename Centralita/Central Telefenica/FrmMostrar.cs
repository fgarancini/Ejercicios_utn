using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace Central_Telefenica
{
    public partial class FrmMenu : Form
    {
        public Centralita centralita = new Centralita("Telefonica");

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador llamada = new FrmLlamador();
            DialogResult dialogResult = llamada.ShowDialog();
            switch (llamada.NroALlamar.First().ToString())
            {
                case "#":
                    //if (ChequearNumero(NroALlamar))
                    //{
                    Provincial provincial = new Provincial(llamada.NroOrigen, llamada.franjas, llamada.duracion.Next(1, 50), llamada.NroALlamar);
                    centralita += provincial;
                    //MessageBox.Show("Llamada agregada con exito");
                    //}
                    break;
                default:
                    float costoF = (float)(0.5 + (llamada.costo.NextDouble() * (6.5 - 0.5)));
                    //if (ChequearNumero(NroALlamar))
                    //{
                    Local local = new Local(llamada.NroOrigen, llamada.duracion.Next(1, 50), llamada.NroALlamar, costoF);
                    centralita += local;
                    //MessageBox.Show("Llamada agregada con exito");

                    //}
                    break;
            }
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            StringBuilder datosFacturacionTotal = new StringBuilder();
            datosFacturacionTotal.AppendLine($"Ganancias totales{centralita.GananciasPorTotal.ToString()}");
            datosFacturacionTotal.AppendLine($"{centralita.ToString()}");

            FormInformes informes = new FormInformes(datosFacturacionTotal.ToString());

            informes.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            StringBuilder datosFacturacionLocal = new StringBuilder();
            
            datosFacturacionLocal.AppendLine($"Ganancias Locales: {centralita.GananciasPorLocal}");
            datosFacturacionLocal.AppendLine($"{centralita.ToString()}");

            FormInformes informes = new FormInformes(datosFacturacionLocal.ToString());

            informes.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            StringBuilder datosFacturacionProvincial = new StringBuilder();

            datosFacturacionProvincial.AppendLine($"Ganancias Locales: {centralita.GananciasPorProvincial}");
            datosFacturacionProvincial.AppendLine($"{centralita.ToString()}");

            FormInformes informes = new FormInformes(datosFacturacionProvincial.ToString());

            informes.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
