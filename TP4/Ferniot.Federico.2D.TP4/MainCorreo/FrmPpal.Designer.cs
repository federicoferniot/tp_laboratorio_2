namespace MainCorreo
{
	partial class FrmPpal
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
			this.grbEstadosPaquetes = new System.Windows.Forms.GroupBox();
			this.lstEstadoIngresado = new System.Windows.Forms.ListBox();
			this.lblEstadoIngresado = new System.Windows.Forms.Label();
			this.lblEstadoEnViaje = new System.Windows.Forms.Label();
			this.lblEstadoEntregado = new System.Windows.Forms.Label();
			this.lstEstadoEnViaje = new System.Windows.Forms.ListBox();
			this.lstEstadoEntregado = new System.Windows.Forms.ListBox();
			this.rtbMostrar = new System.Windows.Forms.RichTextBox();
			this.grbPaquete = new System.Windows.Forms.GroupBox();
			this.lblTrackingID = new System.Windows.Forms.Label();
			this.mtxtTrackingID = new System.Windows.Forms.MaskedTextBox();
			this.lblDireccion = new System.Windows.Forms.Label();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnMostrarTodos = new System.Windows.Forms.Button();
			this.grbEstadosPaquetes.SuspendLayout();
			this.grbPaquete.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbEstadosPaquetes
			// 
			this.grbEstadosPaquetes.Controls.Add(this.lstEstadoEntregado);
			this.grbEstadosPaquetes.Controls.Add(this.lstEstadoEnViaje);
			this.grbEstadosPaquetes.Controls.Add(this.lblEstadoEntregado);
			this.grbEstadosPaquetes.Controls.Add(this.lblEstadoEnViaje);
			this.grbEstadosPaquetes.Controls.Add(this.lblEstadoIngresado);
			this.grbEstadosPaquetes.Controls.Add(this.lstEstadoIngresado);
			this.grbEstadosPaquetes.Location = new System.Drawing.Point(12, 12);
			this.grbEstadosPaquetes.Name = "grbEstadosPaquetes";
			this.grbEstadosPaquetes.Size = new System.Drawing.Size(776, 287);
			this.grbEstadosPaquetes.TabIndex = 0;
			this.grbEstadosPaquetes.TabStop = false;
			this.grbEstadosPaquetes.Text = "Estados Paquetes";
			// 
			// lstEstadoIngresado
			// 
			this.lstEstadoIngresado.FormattingEnabled = true;
			this.lstEstadoIngresado.Location = new System.Drawing.Point(6, 59);
			this.lstEstadoIngresado.Name = "lstEstadoIngresado";
			this.lstEstadoIngresado.Size = new System.Drawing.Size(171, 212);
			this.lstEstadoIngresado.TabIndex = 0;
			// 
			// lblEstadoIngresado
			// 
			this.lblEstadoIngresado.AutoSize = true;
			this.lblEstadoIngresado.Location = new System.Drawing.Point(6, 35);
			this.lblEstadoIngresado.Name = "lblEstadoIngresado";
			this.lblEstadoIngresado.Size = new System.Drawing.Size(54, 13);
			this.lblEstadoIngresado.TabIndex = 1;
			this.lblEstadoIngresado.Text = "Ingresado";
			// 
			// lblEstadoEnViaje
			// 
			this.lblEstadoEnViaje.AutoSize = true;
			this.lblEstadoEnViaje.Location = new System.Drawing.Point(236, 35);
			this.lblEstadoEnViaje.Name = "lblEstadoEnViaje";
			this.lblEstadoEnViaje.Size = new System.Drawing.Size(45, 13);
			this.lblEstadoEnViaje.TabIndex = 2;
			this.lblEstadoEnViaje.Text = "En viaje";
			// 
			// lblEstadoEntregado
			// 
			this.lblEstadoEntregado.AutoSize = true;
			this.lblEstadoEntregado.Location = new System.Drawing.Point(503, 35);
			this.lblEstadoEntregado.Name = "lblEstadoEntregado";
			this.lblEstadoEntregado.Size = new System.Drawing.Size(56, 13);
			this.lblEstadoEntregado.TabIndex = 3;
			this.lblEstadoEntregado.Text = "Entregado";
			// 
			// lstEstadoEnViaje
			// 
			this.lstEstadoEnViaje.FormattingEnabled = true;
			this.lstEstadoEnViaje.Location = new System.Drawing.Point(239, 59);
			this.lstEstadoEnViaje.Name = "lstEstadoEnViaje";
			this.lstEstadoEnViaje.Size = new System.Drawing.Size(223, 212);
			this.lstEstadoEnViaje.TabIndex = 4;
			// 
			// lstEstadoEntregado
			// 
			this.lstEstadoEntregado.FormattingEnabled = true;
			this.lstEstadoEntregado.Location = new System.Drawing.Point(506, 59);
			this.lstEstadoEntregado.Name = "lstEstadoEntregado";
			this.lstEstadoEntregado.Size = new System.Drawing.Size(220, 212);
			this.lstEstadoEntregado.TabIndex = 5;
			// 
			// rtbMostrar
			// 
			this.rtbMostrar.Location = new System.Drawing.Point(18, 306);
			this.rtbMostrar.Name = "rtbMostrar";
			this.rtbMostrar.Size = new System.Drawing.Size(405, 132);
			this.rtbMostrar.TabIndex = 1;
			this.rtbMostrar.Text = "";
			// 
			// grbPaquete
			// 
			this.grbPaquete.Controls.Add(this.btnMostrarTodos);
			this.grbPaquete.Controls.Add(this.btnAgregar);
			this.grbPaquete.Controls.Add(this.txtDireccion);
			this.grbPaquete.Controls.Add(this.lblDireccion);
			this.grbPaquete.Controls.Add(this.mtxtTrackingID);
			this.grbPaquete.Controls.Add(this.lblTrackingID);
			this.grbPaquete.Location = new System.Drawing.Point(429, 306);
			this.grbPaquete.Name = "grbPaquete";
			this.grbPaquete.Size = new System.Drawing.Size(359, 132);
			this.grbPaquete.TabIndex = 2;
			this.grbPaquete.TabStop = false;
			this.grbPaquete.Text = "Paquete";
			// 
			// lblTrackingID
			// 
			this.lblTrackingID.AutoSize = true;
			this.lblTrackingID.Location = new System.Drawing.Point(7, 20);
			this.lblTrackingID.Name = "lblTrackingID";
			this.lblTrackingID.Size = new System.Drawing.Size(63, 13);
			this.lblTrackingID.TabIndex = 0;
			this.lblTrackingID.Text = "Tracking ID";
			// 
			// mtxtTrackingID
			// 
			this.mtxtTrackingID.Location = new System.Drawing.Point(10, 47);
			this.mtxtTrackingID.Name = "mtxtTrackingID";
			this.mtxtTrackingID.Size = new System.Drawing.Size(246, 20);
			this.mtxtTrackingID.TabIndex = 1;
			// 
			// lblDireccion
			// 
			this.lblDireccion.AutoSize = true;
			this.lblDireccion.Location = new System.Drawing.Point(10, 74);
			this.lblDireccion.Name = "lblDireccion";
			this.lblDireccion.Size = new System.Drawing.Size(52, 13);
			this.lblDireccion.TabIndex = 2;
			this.lblDireccion.Text = "Dirección";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(10, 100);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(246, 20);
			this.txtDireccion.TabIndex = 3;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(262, 19);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(91, 47);
			this.btnAgregar.TabIndex = 4;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnMostrarTodos
			// 
			this.btnMostrarTodos.Location = new System.Drawing.Point(262, 80);
			this.btnMostrarTodos.Name = "btnMostrarTodos";
			this.btnMostrarTodos.Size = new System.Drawing.Size(91, 46);
			this.btnMostrarTodos.TabIndex = 5;
			this.btnMostrarTodos.Text = "Mostrar Todos";
			this.btnMostrarTodos.UseVisualStyleBackColor = true;
			this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
			// 
			// FrmPpal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.grbPaquete);
			this.Controls.Add(this.rtbMostrar);
			this.Controls.Add(this.grbEstadosPaquetes);
			this.Name = "FrmPpal";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPpal_FormClosing);
			this.grbEstadosPaquetes.ResumeLayout(false);
			this.grbEstadosPaquetes.PerformLayout();
			this.grbPaquete.ResumeLayout(false);
			this.grbPaquete.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grbEstadosPaquetes;
		private System.Windows.Forms.ListBox lstEstadoEntregado;
		private System.Windows.Forms.ListBox lstEstadoEnViaje;
		private System.Windows.Forms.Label lblEstadoEntregado;
		private System.Windows.Forms.Label lblEstadoEnViaje;
		private System.Windows.Forms.Label lblEstadoIngresado;
		private System.Windows.Forms.ListBox lstEstadoIngresado;
		private System.Windows.Forms.RichTextBox rtbMostrar;
		private System.Windows.Forms.GroupBox grbPaquete;
		private System.Windows.Forms.Button btnMostrarTodos;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.Label lblDireccion;
		private System.Windows.Forms.MaskedTextBox mtxtTrackingID;
		private System.Windows.Forms.Label lblTrackingID;
	}
}

