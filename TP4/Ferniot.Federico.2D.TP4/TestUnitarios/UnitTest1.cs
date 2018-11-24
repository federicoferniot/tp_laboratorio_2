using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;

namespace TestUnitarios
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void CrearNuevoCorreo_SeInstanciaListaDePaquetes()
		{
			List<Paquete> paquetes;
			Correo correo = new Correo();

			paquetes = correo.Paquetes;

			Assert.IsNotNull(paquetes);
		}

		[TestMethod]
		public void CargarDosPaquetesConIdRepetido_LanzaExcepciónTrackingIdRepetidoException()
		{
			string idRepetido = "0";
			Correo correo = new Correo();
			Paquete paqueteUno = new Paquete("Dirección", idRepetido);
			Paquete paqueteDos = new Paquete("Dirección", idRepetido);

			try
			{
				correo += paqueteUno;
				correo += paqueteDos;
				Assert.Fail();
			}
			catch (Exception e)
			{
				Assert.AreEqual(typeof(TrackingIdRepetidoException), e.GetType());
			}
		}
	}
}
