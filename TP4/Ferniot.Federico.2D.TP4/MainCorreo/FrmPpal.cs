using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MainCorreo
{
	public partial class FrmPpal : Form
	{
		Correo correo;

		public FrmPpal()
		{
			InitializeComponent();
			this.correo = new Correo();
		}
		/// <summary>
		/// Actualiza las listas mostrando los paquetes según su estado
		/// </summary>
		private void ActualizarEstados()
		{
			lstEstadoIngresado.Items.Clear();
			lstEstadoEnViaje.Items.Clear();
			lstEstadoEntregado.Items.Clear();
			foreach (Paquete paquete in this.correo.Paquetes)
			{
				switch (paquete.Estado)
				{
					case Paquete.EEstado.Ingresado:
						lstEstadoIngresado.Items.Add(paquete);
						break;
					case Paquete.EEstado.EnViaje:
						lstEstadoEnViaje.Items.Add(paquete);
						break;
					case Paquete.EEstado.Entregado:
						lstEstadoEntregado.Items.Add(paquete);
						break;
				}
			}
		}
		/// <summary>
		/// Muestra la información del elemento dado
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="elemento"></param>
		private void MostrarInformacion<T>(IMostrar<T> elemento)
		{
			if (!(elemento is null))
			{
				this.rtbMostrar.Text = elemento.MostrarDatos(elemento);
				elemento.MostrarDatos(elemento).Guardar("salida.txt");
			}
		}
		/// <summary>
		/// Llama a actualizar estados para mostrar los paquetes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void paq_InformaEstado(object sender, EventArgs e)
		{
			if (this.InvokeRequired)
			{
				Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
				this.Invoke(d, new object[] { sender, e });
			}
			else
			{
				this.ActualizarEstados();
			} 
		}
		/// <summary>
		/// Muestra mensaje de error
		/// </summary>
		/// <param name="mensaje"></param>
		private void paq_InformaError(string mensaje)
		{
			MessageBox.Show(mensaje);
		}
		/// <summary>
		/// Agrega un nuevo paquete al correo
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnAgregar_Click(object sender, EventArgs e)
		{
			Paquete paquete = new Paquete(this.txtDireccion.Text, this.mtxtTrackingID.Text);
			paquete.InformaEstado += this.paq_InformaEstado;
			paquete.InformaError += this.paq_InformaError;
			try
			{
				this.correo += paquete;
			}
			catch (TrackingIdRepetidoException exception)
			{
				MessageBox.Show(exception.Message);
			}
			this.ActualizarEstados();
		}

		private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.correo.FinEntregas();
		}
		/// <summary>
		/// Muestra la información de todos los paquetes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnMostrarTodos_Click(object sender, EventArgs e)
		{
			this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
		}
		/// <summary>
		/// Muestra la información del paquete seleccionado
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
		}
	}
}
