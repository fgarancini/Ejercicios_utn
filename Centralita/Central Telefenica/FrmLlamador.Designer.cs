namespace Central_Telefenica
{
    partial class FrmLlamador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumeroA_Llamar = new System.Windows.Forms.TextBox();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNumOrigen = new System.Windows.Forms.TextBox();
            this.cmbFranja = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Num_Numeral = new System.Windows.Forms.Button();
            this.Num_1 = new System.Windows.Forms.Button();
            this.Num_0 = new System.Windows.Forms.Button();
            this.Num_2 = new System.Windows.Forms.Button();
            this.Num_9 = new System.Windows.Forms.Button();
            this.Num_4 = new System.Windows.Forms.Button();
            this.Num_8 = new System.Windows.Forms.Button();
            this.Num_3 = new System.Windows.Forms.Button();
            this.Num_6 = new System.Windows.Forms.Button();
            this.Num_7 = new System.Windows.Forms.Button();
            this.Num_asterisco = new System.Windows.Forms.Button();
            this.Num_5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumeroA_Llamar
            // 
            this.lblNumeroA_Llamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblNumeroA_Llamar.Location = new System.Drawing.Point(34, 32);
            this.lblNumeroA_Llamar.Name = "lblNumeroA_Llamar";
            this.lblNumeroA_Llamar.Size = new System.Drawing.Size(416, 32);
            this.lblNumeroA_Llamar.TabIndex = 0;
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(246, 153);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(204, 43);
            this.btnLlamar.TabIndex = 3;
            this.btnLlamar.Text = "Llamar";
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(246, 202);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(204, 43);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(246, 310);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(204, 43);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtNumOrigen
            // 
            this.txtNumOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtNumOrigen.Location = new System.Drawing.Point(246, 263);
            this.txtNumOrigen.Name = "txtNumOrigen";
            this.txtNumOrigen.Size = new System.Drawing.Size(204, 32);
            this.txtNumOrigen.TabIndex = 0;
            // 
            // cmbFranja
            // 
            this.cmbFranja.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbFranja.FormattingEnabled = true;
            this.cmbFranja.Location = new System.Drawing.Point(34, 389);
            this.cmbFranja.Name = "cmbFranja";
            this.cmbFranja.Size = new System.Drawing.Size(416, 33);
            this.cmbFranja.TabIndex = 4;
            this.cmbFranja.Text = "Franja";
            this.cmbFranja.SelectedIndexChanged += new System.EventHandler(this.cmbFranja_SelectedIndexChanged);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(246, 104);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(204, 43);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Num_Numeral);
            this.groupBox1.Controls.Add(this.Num_1);
            this.groupBox1.Controls.Add(this.Num_0);
            this.groupBox1.Controls.Add(this.Num_2);
            this.groupBox1.Controls.Add(this.Num_9);
            this.groupBox1.Controls.Add(this.Num_4);
            this.groupBox1.Controls.Add(this.Num_8);
            this.groupBox1.Controls.Add(this.Num_3);
            this.groupBox1.Controls.Add(this.Num_6);
            this.groupBox1.Controls.Add(this.Num_7);
            this.groupBox1.Controls.Add(this.Num_asterisco);
            this.groupBox1.Controls.Add(this.Num_5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(24, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 275);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panel";
            // 
            // Num_Numeral
            // 
            this.Num_Numeral.Location = new System.Drawing.Point(131, 206);
            this.Num_Numeral.Name = "Num_Numeral";
            this.Num_Numeral.Size = new System.Drawing.Size(50, 44);
            this.Num_Numeral.TabIndex = 0;
            this.Num_Numeral.Text = "#";
            this.Num_Numeral.UseVisualStyleBackColor = true;
            this.Num_Numeral.Click += new System.EventHandler(this.Num_Numeral_Click);
            // 
            // Num_1
            // 
            this.Num_1.Location = new System.Drawing.Point(19, 34);
            this.Num_1.Name = "Num_1";
            this.Num_1.Size = new System.Drawing.Size(50, 44);
            this.Num_1.TabIndex = 0;
            this.Num_1.Text = "1";
            this.Num_1.UseVisualStyleBackColor = true;
            this.Num_1.Click += new System.EventHandler(this.Num_1_Click);
            // 
            // Num_0
            // 
            this.Num_0.Location = new System.Drawing.Point(75, 206);
            this.Num_0.Name = "Num_0";
            this.Num_0.Size = new System.Drawing.Size(50, 44);
            this.Num_0.TabIndex = 0;
            this.Num_0.Text = "0";
            this.Num_0.UseVisualStyleBackColor = true;
            this.Num_0.Click += new System.EventHandler(this.Num_0_Click);
            // 
            // Num_2
            // 
            this.Num_2.Location = new System.Drawing.Point(75, 34);
            this.Num_2.Name = "Num_2";
            this.Num_2.Size = new System.Drawing.Size(50, 44);
            this.Num_2.TabIndex = 0;
            this.Num_2.Text = "2";
            this.Num_2.UseVisualStyleBackColor = true;
            this.Num_2.Click += new System.EventHandler(this.Num_2_Click);
            // 
            // Num_9
            // 
            this.Num_9.Location = new System.Drawing.Point(131, 148);
            this.Num_9.Name = "Num_9";
            this.Num_9.Size = new System.Drawing.Size(50, 44);
            this.Num_9.TabIndex = 0;
            this.Num_9.Text = "9";
            this.Num_9.UseVisualStyleBackColor = true;
            this.Num_9.Click += new System.EventHandler(this.Num_9_Click);
            // 
            // Num_4
            // 
            this.Num_4.Location = new System.Drawing.Point(19, 92);
            this.Num_4.Name = "Num_4";
            this.Num_4.Size = new System.Drawing.Size(50, 44);
            this.Num_4.TabIndex = 0;
            this.Num_4.Text = "4";
            this.Num_4.UseVisualStyleBackColor = true;
            this.Num_4.Click += new System.EventHandler(this.Num_4_Click);
            // 
            // Num_8
            // 
            this.Num_8.Location = new System.Drawing.Point(75, 148);
            this.Num_8.Name = "Num_8";
            this.Num_8.Size = new System.Drawing.Size(50, 44);
            this.Num_8.TabIndex = 0;
            this.Num_8.Text = "8";
            this.Num_8.UseVisualStyleBackColor = true;
            this.Num_8.Click += new System.EventHandler(this.Num_8_Click);
            // 
            // Num_3
            // 
            this.Num_3.Location = new System.Drawing.Point(131, 34);
            this.Num_3.Name = "Num_3";
            this.Num_3.Size = new System.Drawing.Size(50, 44);
            this.Num_3.TabIndex = 0;
            this.Num_3.Text = "3";
            this.Num_3.UseVisualStyleBackColor = true;
            this.Num_3.Click += new System.EventHandler(this.Num_3_Click);
            // 
            // Num_6
            // 
            this.Num_6.Location = new System.Drawing.Point(131, 92);
            this.Num_6.Name = "Num_6";
            this.Num_6.Size = new System.Drawing.Size(50, 44);
            this.Num_6.TabIndex = 0;
            this.Num_6.Text = "6";
            this.Num_6.UseVisualStyleBackColor = true;
            this.Num_6.Click += new System.EventHandler(this.Num_6_Click);
            // 
            // Num_7
            // 
            this.Num_7.Location = new System.Drawing.Point(19, 148);
            this.Num_7.Name = "Num_7";
            this.Num_7.Size = new System.Drawing.Size(50, 44);
            this.Num_7.TabIndex = 0;
            this.Num_7.Text = "7";
            this.Num_7.UseVisualStyleBackColor = true;
            this.Num_7.Click += new System.EventHandler(this.Num_7_Click);
            // 
            // Num_asterisco
            // 
            this.Num_asterisco.Location = new System.Drawing.Point(19, 206);
            this.Num_asterisco.Name = "Num_asterisco";
            this.Num_asterisco.Size = new System.Drawing.Size(50, 44);
            this.Num_asterisco.TabIndex = 0;
            this.Num_asterisco.Text = "*";
            this.Num_asterisco.UseVisualStyleBackColor = true;
            this.Num_asterisco.Click += new System.EventHandler(this.Num_asterisco_Click);
            // 
            // Num_5
            // 
            this.Num_5.Location = new System.Drawing.Point(75, 92);
            this.Num_5.Name = "Num_5";
            this.Num_5.Size = new System.Drawing.Size(50, 44);
            this.Num_5.TabIndex = 0;
            this.Num_5.Text = "5";
            this.Num_5.UseVisualStyleBackColor = true;
            this.Num_5.Click += new System.EventHandler(this.Num_5_Click);
            // 
            // FrmLlamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 448);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbFranja);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.txtNumOrigen);
            this.Controls.Add(this.lblNumeroA_Llamar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmLlamador";
            this.Text = "Llamador";
            this.Load += new System.EventHandler(this.FrmLlamador_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lblNumeroA_Llamar;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNumOrigen;
        private System.Windows.Forms.ComboBox cmbFranja;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Num_Numeral;
        private System.Windows.Forms.Button Num_1;
        private System.Windows.Forms.Button Num_0;
        private System.Windows.Forms.Button Num_2;
        private System.Windows.Forms.Button Num_9;
        private System.Windows.Forms.Button Num_4;
        private System.Windows.Forms.Button Num_8;
        private System.Windows.Forms.Button Num_3;
        private System.Windows.Forms.Button Num_6;
        private System.Windows.Forms.Button Num_7;
        private System.Windows.Forms.Button Num_asterisco;
        private System.Windows.Forms.Button Num_5;
    }
}