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
    public partial class FrmLlamador : Form
    {
        public Centralita centralita = new Centralita();
        public Random duracion = new Random();
        public Random costo = new Random();
        public Franja franjas;

        public FrmLlamador()
        {
            InitializeComponent();
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            this.cmbFranja.Enabled = false;

            // Carga 
            cmbFranja.DataSource = Enum.GetValues(typeof(Franja));
            // Lectura 
            Enum.TryParse<Franja>(cmbFranja.SelectedValue.ToString(), out franjas);

            NroOrigen = "#1135920587";
        }
        private void btnLlamar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Llamada agregada con exito");
        }
        public Centralita Centralita
        {
            get
            {
                return this.centralita;
            }
        }
        public string NroALlamar
        {
            get
            {
                return this.lblNumeroA_Llamar.Text;
            }
            set
            {
                this.lblNumeroA_Llamar.Text = value;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.txtNumOrigen.Text;
            }
            set
            {
                this.txtNumOrigen.Text = value;
            }
        }
        private void Num_1_Click(object sender, EventArgs e)
        {
            lblNumeroA_Llamar.Text += "1";
        }

        private void Num_2_Click(object sender, EventArgs e)
        {
            lblNumeroA_Llamar.Text += "2";
        }

        private void Num_3_Click(object sender, EventArgs e)
        {
            lblNumeroA_Llamar.Text += "3";
        }

        private void Num_4_Click(object sender, EventArgs e)
        {
            lblNumeroA_Llamar.Text += "4";
        }

        private void Num_5_Click(object sender, EventArgs e)
        {
            lblNumeroA_Llamar.Text += "5";
        }

        private void Num_6_Click(object sender, EventArgs e)
        {
            lblNumeroA_Llamar.Text += "6";
        }

        private void Num_7_Click(object sender, EventArgs e)
        {
            lblNumeroA_Llamar.Text += "7";
        }

        private void Num_8_Click(object sender, EventArgs e)
        {
            lblNumeroA_Llamar.Text += "8";
        }

        private void Num_9_Click(object sender, EventArgs e)
        {
            lblNumeroA_Llamar.Text += "9";
        }

        private void Num_asterisco_Click(object sender, EventArgs e)
        {
            lblNumeroA_Llamar.Text += "*";
        }

        private void Num_0_Click(object sender, EventArgs e)
        {
            lblNumeroA_Llamar.Text += "0";
        }

        private void Num_Numeral_Click(object sender, EventArgs e)
        {
            lblNumeroA_Llamar.Text += "#";
            if (NroALlamar.Length == 1)
            {
                this.cmbFranja.Enabled = true;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string remove = this.NroALlamar;
            this.NroALlamar = remove.Remove(remove.Length - 1);            
        }

        private static bool ChequearNumero(string numero)
        {
            if (numero.Length >= 11)
            {
                return true;
            }
            return false;
        }

        private void cmbFranja_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.NroALlamar = "";
        }
    }
}
