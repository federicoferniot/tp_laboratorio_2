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

		public Correo()
		{
			this.mockPaquete = new List<Thread>();
			this.paquetes = new List<Paquete>();
		}

		public void FinEntregas()
		{
			foreach (Thread thread in mockPaquete)
			{
				if (thread.IsAlive)
					thread.Abort();
			}
		}

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
	}
}
