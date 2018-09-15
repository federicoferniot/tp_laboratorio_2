namespace MiCalculadora
{
    partial class LaCalculadora
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
			this.txtNumero1 = new System.Windows.Forms.TextBox();
			this.cmbOperador = new System.Windows.Forms.ComboBox();
			this.txtNumero2 = new System.Windows.Forms.TextBox();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnOperar = new System.Windows.Forms.Button();
			this.btnConvertirABinario = new System.Windows.Forms.Button();
			this.btnConvertirADecimal = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.pnlResultado = new System.Windows.Forms.Panel();
			this.pnlResultado.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtNumero1
			// 
			this.txtNumero1.Location = new System.Drawing.Point(49, 36);
			this.txtNumero1.Name = "txtNumero1";
			this.txtNumero1.Size = new System.Drawing.Size(129, 20);
			this.txtNumero1.TabIndex = 0;
			// 
			// cmbOperador
			// 
			this.cmbOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbOperador.FormattingEnabled = true;
			this.cmbOperador.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
			this.cmbOperador.Location = new System.Drawing.Point(184, 36);
			this.cmbOperador.Name = "cmbOperador";
			this.cmbOperador.Size = new System.Drawing.Size(38, 21);
			this.cmbOperador.TabIndex = 1;
			// 
			// txtNumero2
			// 
			this.txtNumero2.Location = new System.Drawing.Point(228, 36);
			this.txtNumero2.Name = "txtNumero2";
			this.txtNumero2.Size = new System.Drawing.Size(129, 20);
			this.txtNumero2.TabIndex = 2;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(158, 62);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(86, 23);
			this.btnLimpiar.TabIndex = 4;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(271, 62);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(86, 23);
			this.btnCerrar.TabIndex = 5;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// btnOperar
			// 
			this.btnOperar.Location = new System.Drawing.Point(49, 62);
			this.btnOperar.Name = "btnOperar";
			this.btnOperar.Size = new System.Drawing.Size(86, 23);
			this.btnOperar.TabIndex = 6;
			this.btnOperar.Text = "Operar";
			this.btnOperar.UseVisualStyleBackColor = true;
			this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
			// 
			// btnConvertirABinario
			// 
			this.btnConvertirABinario.Location = new System.Drawing.Point(49, 91);
			this.btnConvertirABinario.Name = "btnConvertirABinario";
			this.btnConvertirABinario.Size = new System.Drawing.Size(151, 23);
			this.btnConvertirABinario.TabIndex = 7;
			this.btnConvertirABinario.Text = "Convertir a Binario";
			this.btnConvertirABinario.UseVisualStyleBackColor = true;
			this.btnConvertirABinario.Click += new System.EventHandler(this.btnConvertirABinario_Click);
			// 
			// btnConvertirADecimal
			// 
			this.btnConvertirADecimal.Location = new System.Drawing.Point(206, 91);
			this.btnConvertirADecimal.Name = "btnConvertirADecimal";
			this.btnConvertirADecimal.Size = new System.Drawing.Size(151, 23);
			this.btnConvertirADecimal.TabIndex = 8;
			this.btnConvertirADecimal.Text = "Convertir a Decimal";
			this.btnConvertirADecimal.UseVisualStyleBackColor = true;
			this.btnConvertirADecimal.Click += new System.EventHandler(this.btnConvertirADecimal_Click);
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Dock = System.Windows.Forms.DockStyle.Right;
			this.lblResultado.Location = new System.Drawing.Point(308, 0);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblResultado.Size = new System.Drawing.Size(0, 13);
			this.lblResultado.TabIndex = 9;
			this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlResultado
			// 
			this.pnlResultado.Controls.Add(this.lblResultado);
			this.pnlResultado.Location = new System.Drawing.Point(49, 10);
			this.pnlResultado.Name = "pnlResultado";
			this.pnlResultado.Size = new System.Drawing.Size(308, 20);
			this.pnlResultado.TabIndex = 10;
			// 
			// LaCalculadora
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(407, 132);
			this.Controls.Add(this.pnlResultado);
			this.Controls.Add(this.btnConvertirADecimal);
			this.Controls.Add(this.btnConvertirABinario);
			this.Controls.Add(this.btnOperar);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.txtNumero2);
			this.Controls.Add(this.cmbOperador);
			this.Controls.Add(this.txtNumero1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LaCalculadora";
			this.Text = "Calculadora de Federico Ferniot del curso 2°D";
			this.Load += new System.EventHandler(this.LaCalculadora_Load);
			this.pnlResultado.ResumeLayout(false);
			this.pnlResultado.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnConvertirABinario;
        private System.Windows.Forms.Button btnConvertirADecimal;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Panel pnlResultado;
	}
}

