using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
	public class Paquete: IMostrar<Paquete>
	{
		public delegate void DelegadoEstado(object sender, EventArgs e);
		public delegate void DelegadoError(string mensaje);
		public event DelegadoEstado InformaEstado;
		public event DelegadoError InformaError;
		public enum EEstado
		{
			Ingresado,
			EnViaje,
			Entregado
		}

		private string direccionEntrega;
		private EEstado estado;
		private string trackingID;

		#region Propiedades
		/// <summary>
		/// Devuelve o setea la dirección de entrega del paquete
		/// </summary>
		public string DireccionEntrega
		{
			get
			{
				return this.direccionEntrega;
			}
			set
			{
				this.direccionEntrega = value;
			}
		}
		/// <summary>
		/// Devuelve o setea el estado en el que se encuentra el paquete
		/// </summary>
		public EEstado Estado
		{
			get
			{
				return this.estado;
			}
			set
			{
				this.estado = value;
			}
		}
		/// <summary>
		/// Devuelve o setea el TrackingID del paquete
		/// </summary>
		public string TrackingID
		{
			get
			{
				return this.trackingID;
			}
			set
			{
				this.trackingID = value;
			}
		}
		#endregion

		#region Constructores
		/// <summary>
		/// Crea una nueva instancia de Paquete, con dirección y trackingID dados
		/// </summary>
		/// <param name="direccionEntrega"></param>
		/// <param name="trackingID"></param>
		public Paquete(string direccionEntrega, string trackingID)
		{
			this.direccionEntrega = direccionEntrega;
			this.trackingID = trackingID;
			this.estado = default(EEstado);
		}
		#endregion

		#region Métodos
		/// <summary>
		/// Devuelve los datos del paquete
		/// </summary>
		/// <param name="elemento"></param>
		/// <returns></returns>
		public string MostrarDatos(IMostrar<Paquete> elemento)
		{
			Paquete paquete = (Paquete)elemento;

			return string.Format("{0} para {1}\r\n", paquete.trackingID, paquete.direccionEntrega);
		}
		/// <summary>
		/// Devuelve los datos del paquete
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return this.MostrarDatos((IMostrar<Paquete>)this);
		}
		/// <summary>
		/// Simula un ciclo de vida del paquete,
		/// Luego lo guarda en la base de datos
		/// </summary>
		public void MockCicloDeVida()
		{
			while (this.estado != EEstado.Entregado)
			{
				Thread.Sleep(4000);
				this.estado++;
				this.InformaEstado.Invoke(null, null);
			}
			try
			{
				PaqueteDAO.Insertar(this);
			}
			catch (Exception e)
			{
				this.InformaError(e.Message);
			}
		}
		#endregion

		#region Operadores
		/// <summary>
		/// Dos paquetes son iguales si sus TrackingID son iguales
		/// </summary>
		/// <param name="paqueteUno"></param>
		/// <param name="paqueteDos"></param>
		/// <returns></returns>
		public static bool operator ==(Paquete paqueteUno, Paquete paqueteDos)
		{
			return (paqueteUno.TrackingID == paqueteDos.TrackingID);
		}
		/// <summary>
		/// Dos paquetes son distintos si sus TrackingID no son iguales
		/// </summary>
		/// <param name="paqueteUno"></param>
		/// <param name="paqueteDos"></param>
		/// <returns></returns>
		public static bool operator !=(Paquete paqueteUno, Paquete paqueteDos)
		{
			return !(paqueteUno == paqueteDos);
		}
		#endregion
	}
}
