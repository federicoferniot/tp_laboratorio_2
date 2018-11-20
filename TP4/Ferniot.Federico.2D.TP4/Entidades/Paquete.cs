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
		public event DelegadoEstado InformaEstado;
		public enum EEstado
		{
			Ingresado,
			EnViaje,
			Entregado
		}

		private string direccionEntrega;
		private EEstado estado;
		private string trackingID;

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

		public Paquete(string direccionEntrega, string trackingID)
		{
			this.direccionEntrega = direccionEntrega;
			this.trackingID = trackingID;
			this.estado = default(EEstado);
		}


		public string MostrarDatos(IMostrar<Paquete> elemento)
		{
			Paquete paquete = (Paquete)elemento;

			return string.Format("{0} para {1}", paquete.trackingID, paquete.direccionEntrega);
		}

		public override string ToString()
		{
			return this.MostrarDatos((IMostrar<Paquete>)this);
		}

		public void MockCicloDeVida()
		{
			while (this.estado != EEstado.Entregado)
			{
				Thread.Sleep(4000);
				this.estado++;
				this.InformaEstado.Invoke(null, null);
			}
			PaqueteDAO.Insertar(this);
		}


		public static bool operator ==(Paquete paqueteUno, Paquete paqueteDos)
		{
			return (paqueteUno.TrackingID == paqueteDos.TrackingID);
		}

		public static bool operator !=(Paquete paqueteUno, Paquete paqueteDos)
		{
			return !(paqueteUno == paqueteDos);
		}
	}
}
