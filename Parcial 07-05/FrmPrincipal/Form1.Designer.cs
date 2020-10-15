namespace FrmPrincipal
{
    partial class Form1
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
            this.rtbSalidaDeTest = new System.Windows.Forms.RichTextBox();
            this.btnBotton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbSalidaDeTest
            // 
            this.rtbSalidaDeTest.Location = new System.Drawing.Point(8, 83);
            this.rtbSalidaDeTest.Name = "rtbSalidaDeTest";
            this.rtbSalidaDeTest.Size = new System.Drawing.Size(780, 355);
            this.rtbSalidaDeTest.TabIndex = 0;
            this.rtbSalidaDeTest.Text = "";
            // 
            // btnBotton1
            // 
            this.btnBotton1.Location = new System.Drawing.Point(598, 12);
            this.btnBotton1.Name = "btnBotton1";
            this.btnBotton1.Size = new System.Drawing.Size(190, 65);
            this.btnBotton1.TabIndex = 1;
            this.btnBotton1.Text = "Ver datos";
            this.btnBotton1.UseVisualStyleBackColor = true;
            this.btnBotton1.Click += new System.EventHandler(this.btnBotton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBotton1);
            this.Controls.Add(this.rtbSalidaDeTest);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jardin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSalidaDeTest;
        private System.Windows.Forms.Button btnBotton1;
    }
}

