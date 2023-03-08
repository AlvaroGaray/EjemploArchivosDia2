namespace BibliotecaBanco
{
    partial class frmBancoUI
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
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.txtprimerNom = new System.Windows.Forms.TextBox();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(149, 202);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(209, 23);
            this.txtSaldo.TabIndex = 15;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(37, 205);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(36, 15);
            this.lblSaldo.TabIndex = 14;
            this.lblSaldo.Text = "Saldo";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(149, 145);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(209, 23);
            this.txtApellidoPaterno.TabIndex = 13;
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Location = new System.Drawing.Point(37, 148);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(95, 15);
            this.lblApellidoPaterno.TabIndex = 12;
            this.lblApellidoPaterno.Text = "Apellido Paterno";
            // 
            // txtprimerNom
            // 
            this.txtprimerNom.Location = new System.Drawing.Point(149, 94);
            this.txtprimerNom.Name = "txtprimerNom";
            this.txtprimerNom.Size = new System.Drawing.Size(209, 23);
            this.txtprimerNom.TabIndex = 11;
            // 
            // lblPrimerNombre
            // 
            this.lblPrimerNombre.AutoSize = true;
            this.lblPrimerNombre.Location = new System.Drawing.Point(37, 97);
            this.lblPrimerNombre.Name = "lblPrimerNombre";
            this.lblPrimerNombre.Size = new System.Drawing.Size(89, 15);
            this.lblPrimerNombre.TabIndex = 10;
            this.lblPrimerNombre.Text = "Primer Nombre";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(149, 35);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(209, 23);
            this.txtCuenta.TabIndex = 9;
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(37, 38);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(45, 15);
            this.lblCuenta.TabIndex = 8;
            this.lblCuenta.Text = "Cuenta";
            // 
            // frmBancoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.lblApellidoPaterno);
            this.Controls.Add(this.txtprimerNom);
            this.Controls.Add(this.lblPrimerNombre);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.lblCuenta);
            this.Name = "frmBancoUI";
            this.Text = "frmBancoUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtSaldo;
        private Label lblSaldo;
        private TextBox txtApellidoPaterno;
        private Label lblApellidoPaterno;
        private TextBox txtprimerNom;
        private Label lblPrimerNombre;
        private TextBox txtCuenta;
        private Label lblCuenta;
    }
}