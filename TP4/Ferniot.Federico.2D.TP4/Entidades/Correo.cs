using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Correo: IMostrar<List<Paquete>>
	{
		private List<Thread> mockPaquete;
		private List<Paquete> paquetes;

		#region Propiedades
		/// <summary>
		/// Devuelve o setea la lista de paquetes del correo
		/// </summary>
		public List<Paquete> Paquetes
		{
			get
			{
				return this.paquetes;
			}
			set
			{
				this.paquetes = value;
			}
		}
		#endregion

		#region Constructores
		/// <summary>
		/// Instancia un nuevo correo
		/// </summary>
		public Correo()
		{
			this.mockPaquete = new List<Thread>();
			this.paquetes = new List<Paquete>();
		}
		#endregion

		#region Métodos
		/// <summary>
		/// Finaliza todos los hilos activos del correo
		/// </summary>
		public void FinEntregas()
		{
			foreach (Thread thread in mockPaquete)
			{
				if (thread.IsAlive)
					thread.Abort();
			}
		}
		/// <summary>
		/// Devuelve los datos de todos los paquetes del correo
		/// </summary>
		/// <param name="elementos"></param>
		/// <returns></returns>
		public string MostrarDatos(IMostrar<List<Paquete>> elementos)
		{
			string retorno = "";
			List<Paquete> paquetes = (List<Paquete>)((Correo)elementos).paquetes;
			foreach (Paquete paquete in paquetes)
			{
				retorno += string.Format("{0} para {1} ({2})\r\n", paquete.TrackingID, paquete.DireccionEntrega, paquete.Estado.ToString());
			}
			return retorno;
		}
		#endregion

		#region Operadores
		/// <summary>
		/// Agrega un paquete al correo
		/// </summary>
		/// <param name="correo"></param>
		/// <param name="paquete"></param>
		/// <returns></returns>
		/// <exception cref="TrackingIdRepetidoException">Si el TrackingID ya se encuentra agregado</exception>
		public static Correo operator +(Correo correo, Paquete paquete)
		{
			Thread thread;
			foreach (Paquete paqueteEnCorreo in correo.paquetes)
			{
				if (paqueteEnCorreo == paquete)
					throw new TrackingIdRepetidoException();
			}
			correo.paquetes.Add(paquete);
			thread = new Thread(paquete.MockCicloDeVida);
			correo.mockPaquete.Add(thread);
			thread.Start();
			return correo;
		}
		#endregion
	}
}
