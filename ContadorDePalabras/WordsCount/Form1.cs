using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordsCount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void cajaDeTexto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CalcularPalabras_Click(object sender, EventArgs e)
        {
            string texto = this.cajaDeTexto.Text;
            string[] palabras;
            
            palabras = texto.Split(' ');

            Dictionary<string, int> palabra_dictionary = new Dictionary<string, int>();

            foreach (string palabra in palabras)
            {
                if (!palabra_dictionary.ContainsKey(palabra))
                {
                    palabra_dictionary.Add(palabra, 1);
                }
                else
                {
                    palabra_dictionary[palabra]++;
                }
                
            }

            List<KeyValuePair<string, int>> repeticiones = palabra_dictionary.ToList();
            repeticiones.Sort(OrdenarPorValor);

            //dict.OrderBy(x => x.Value).ToDictionary()

            for (int i = 0; i < 3; i++)
            {
                MessageBox.Show($"Palabra mas repetida {repeticiones[i].Key} , veces: {repeticiones[i].Value}");
            }
        }

        public static int OrdenarPorValor(KeyValuePair<string, int> palabraSigiente, KeyValuePair<string, int> palabraActual)
        {
            int ret = 0;
            if(palabraActual.Value > palabraSigiente.Value)
            {
                ret = 1;
            }
            else if(palabraActual.Value < palabraSigiente.Value)
            {
                ret = -1;
            }

            return ret;

        }
    }
}
