namespace Conver
{
    partial class Conver
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGradosC = new System.Windows.Forms.Label();
            this.lblGradosF = new System.Windows.Forms.Label();
            this.txtGradosC = new System.Windows.Forms.TextBox();
            this.txtGradosF = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGradosC
            // 
            this.lblGradosC.AutoSize = true;
            this.lblGradosC.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGradosC.Location = new System.Drawing.Point(31, 38);
            this.lblGradosC.Name = "lblGradosC";
            this.lblGradosC.Size = new System.Drawing.Size(135, 18);
            this.lblGradosC.TabIndex = 0;
            this.lblGradosC.Text = "Grados Centígrados";
            // 
            // lblGradosF
            // 
            this.lblGradosF.AutoSize = true;
            this.lblGradosF.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGradosF.Location = new System.Drawing.Point(31, 77);
            this.lblGradosF.Name = "lblGradosF";
            this.lblGradosF.Size = new System.Drawing.Size(127, 18);
            this.lblGradosF.TabIndex = 1;
            this.lblGradosF.Text = "Grados Fahrenheit";
            // 
            // txtGradosC
            // 
            this.txtGradosC.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGradosC.Location = new System.Drawing.Point(233, 30);
            this.txtGradosC.Name = "txtGradosC";
            this.txtGradosC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGradosC.Size = new System.Drawing.Size(288, 26);
            this.txtGradosC.TabIndex = 2;
            this.txtGradosC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGradosC_KeyPress);
            // 
            // txtGradosF
            // 
            this.txtGradosF.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGradosF.Location = new System.Drawing.Point(233, 76);
            this.txtGradosF.Name = "txtGradosF";
            this.txtGradosF.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGradosF.Size = new System.Drawing.Size(288, 26);
            this.txtGradosF.TabIndex = 3;
            this.txtGradosF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGradosC_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.Location = new System.Drawing.Point(233, 125);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(288, 32);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Conver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 197);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtGradosF);
            this.Controls.Add(this.txtGradosC);
            this.Controls.Add(this.lblGradosF);
            this.Controls.Add(this.lblGradosC);
            this.Name = "Conver";
            this.Text = "Calculadora de Temperaturas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblGradosC;
        private Label lblGradosF;
        private TextBox txtGradosC;
        private TextBox txtGradosF;
        private Button btnAceptar;
    }
}