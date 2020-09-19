namespace WordsCount
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cajaDeTexto = new System.Windows.Forms.RichTextBox();
            this.CalcularPalabras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cajaDeTexto
            // 
            this.cajaDeTexto.Location = new System.Drawing.Point(12, 12);
            this.cajaDeTexto.Name = "cajaDeTexto";
            this.cajaDeTexto.Size = new System.Drawing.Size(471, 426);
            this.cajaDeTexto.TabIndex = 0;
            this.cajaDeTexto.Text = "";
            this.cajaDeTexto.TextChanged += new System.EventHandler(this.cajaDeTexto_TextChanged);
            // 
            // CalcularPalabras
            // 
            this.CalcularPalabras.Location = new System.Drawing.Point(549, 58);
            this.CalcularPalabras.Name = "CalcularPalabras";
            this.CalcularPalabras.Size = new System.Drawing.Size(204, 47);
            this.CalcularPalabras.TabIndex = 1;
            this.CalcularPalabras.Text = "Calcular";
            this.CalcularPalabras.UseVisualStyleBackColor = true;
            this.CalcularPalabras.Click += new System.EventHandler(this.CalcularPalabras_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalcularPalabras);
            this.Controls.Add(this.cajaDeTexto);
            this.Name = "Form1";
            this.Text = "Contador de Palabras";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox cajaDeTexto;
        private System.Windows.Forms.Button CalcularPalabras;
    }
}

