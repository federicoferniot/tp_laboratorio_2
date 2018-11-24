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
			this.components = new System.ComponentModel.Container();
			this.grbEstadosPaquetes = new System.Windows.Forms.GroupBox();
			this.lstEstadoEntregado = new System.Windows.Forms.ListBox();
			this.lstEstadoEnViaje = new System.Windows.Forms.ListBox();
			this.lblEstadoEntregado = new System.Windows.Forms.Label();
			this.lblEstadoEnViaje = new System.Windows.Forms.Label();
			this.lblEstadoIngresado = new System.Windows.Forms.Label();
			this.lstEstadoIngresado = new System.Windows.Forms.ListBox();
			this.rtbMostrar = new System.Windows.Forms.RichTextBox();
			this.grbPaquete = new System.Windows.Forms.GroupBox();
			this.btnMostrarTodos = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.lblDireccion = new System.Windows.Forms.Label();
			this.mtxtTrackingID = new System.Windows.Forms.MaskedTextBox();
			this.lblTrackingID = new System.Windows.Forms.Label();
			this.cmsListas = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.grbEstadosPaquetes.SuspendLayout();
			this.grbPaquete.SuspendLayout();
			this.cmsListas.SuspendLayout();
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
			// lstEstadoEntregado
			// 
			this.lstEstadoEntregado.ContextMenuStrip = this.cmsListas;
			this.lstEstadoEntregado.FormattingEnabled = true;
			this.lstEstadoEntregado.Location = new System.Drawing.Point(506, 59);
			this.lstEstadoEntregado.Name = "lstEstadoEntregado";
			this.lstEstadoEntregado.Size = new System.Drawing.Size(223, 212);
			this.lstEstadoEntregado.TabIndex = 5;
			// 
			// lstEstadoEnViaje
			// 
			this.lstEstadoEnViaje.FormattingEnabled = true;
			this.lstEstadoEnViaje.Location = new System.Drawing.Point(256, 59);
			this.lstEstadoEnViaje.Name = "lstEstadoEnViaje";
			this.lstEstadoEnViaje.Size = new System.Drawing.Size(223, 212);
			this.lstEstadoEnViaje.TabIndex = 4;
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
			// lblEstadoEnViaje
			// 
			this.lblEstadoEnViaje.AutoSize = true;
			this.lblEstadoEnViaje.Location = new System.Drawing.Point(253, 35);
			this.lblEstadoEnViaje.Name = "lblEstadoEnViaje";
			this.lblEstadoEnViaje.Size = new System.Drawing.Size(45, 13);
			this.lblEstadoEnViaje.TabIndex = 2;
			this.lblEstadoEnViaje.Text = "En viaje";
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
			// lstEstadoIngresado
			// 
			this.lstEstadoIngresado.FormattingEnabled = true;
			this.lstEstadoIngresado.Location = new System.Drawing.Point(9, 59);
			this.lstEstadoIngresado.Name = "lstEstadoIngresado";
			this.lstEstadoIngresado.Size = new System.Drawing.Size(223, 212);
			this.lstEstadoIngresado.TabIndex = 0;
			// 
			// rtbMostrar
			// 
			this.rtbMostrar.Location = new System.Drawing.Point(18, 306);
			this.rtbMostrar.Name = "rtbMostrar";
			this.rtbMostrar.ReadOnly = true;
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
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(10, 100);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(246, 20);
			this.txtDireccion.TabIndex = 3;
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
			// mtxtTrackingID
			// 
			this.mtxtTrackingID.Location = new System.Drawing.Point(10, 47);
			this.mtxtTrackingID.Mask = "000-000-0000";
			this.mtxtTrackingID.Name = "mtxtTrackingID";
			this.mtxtTrackingID.Size = new System.Drawing.Size(246, 20);
			this.mtxtTrackingID.TabIndex = 1;
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
			// cmsListas
			// 
			this.cmsListas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem});
			this.cmsListas.Name = "cmsListas";
			this.cmsListas.Size = new System.Drawing.Size(116, 26);
			// 
			// mostrarToolStripMenuItem
			// 
			this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
			this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.mostrarToolStripMenuItem.Text = "Mostrar";
			this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
			// 
			// FrmPpal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.grbPaquete);
			this.Controls.Add(this.rtbMostrar);
			this.Controls.Add(this.grbEstadosPaquetes);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FrmPpal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Correo UTN por Federico.Ferniot.2D";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPpal_FormClosing);
			this.grbEstadosPaquetes.ResumeLayout(false);
			this.grbEstadosPaquetes.PerformLayout();
			this.grbPaquete.ResumeLayout(false);
			this.grbPaquete.PerformLayout();
			this.cmsListas.ResumeLayout(false);
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
		private System.Windows.Forms.ContextMenuStrip cmsListas;
		private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
	}
}

