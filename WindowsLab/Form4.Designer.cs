namespace WindowsLab
{
    partial class Form4
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
            this.btnArea = new System.Windows.Forms.Button();
            this.lblForma = new System.Windows.Forms.Label();
            this.txtForma = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(159, 115);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(129, 23);
            this.btnArea.TabIndex = 8;
            this.btnArea.Text = "Calcular Area ";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // lblForma
            // 
            this.lblForma.AutoSize = true;
            this.lblForma.Location = new System.Drawing.Point(82, 77);
            this.lblForma.Name = "lblForma";
            this.lblForma.Size = new System.Drawing.Size(186, 13);
            this.lblForma.TabIndex = 9;
            this.lblForma.Text = "Forma(Rectangulo, Circulo, Trapecio):";
            // 
            // txtForma
            // 
            this.txtForma.Location = new System.Drawing.Point(274, 74);
            this.txtForma.Name = "txtForma";
            this.txtForma.Size = new System.Drawing.Size(100, 20);
            this.txtForma.TabIndex = 10;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtForma);
            this.Controls.Add(this.lblForma);
            this.Controls.Add(this.btnArea);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Label lblForma;
        private System.Windows.Forms.TextBox txtForma;
    }
}