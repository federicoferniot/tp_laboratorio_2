using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClasesAbstractas;
using ClasesInstanciables;
using Excepciones;

namespace TestUnitarios
{
	[TestClass]
	public class ProfesorTests
	{
		[TestMethod]
		public void InstanciarProfesorConDniCaracteresInvalidos_LanzaExcepcionDniInvalidoException()
		{
			const string dniInvalido = "Invalido";
			try
			{
				Profesor profesor = new Profesor(0, "Nombre", "Apellido", dniInvalido, Persona.ENacionalidad.Argentino);
			}
			catch (Exception exception)
			{
				Assert.IsInstanceOfType(exception, typeof(DniInvalidoException));
				return;
			}
			Assert.Fail("No lanza excepción para Dni {0}.", dniInvalido);
		}

		[TestMethod]
		public void InstanciarProfesorExtranjeroConDniArgentino_LanzaExcepcionNacionalidadInvalidaException()
		{
			const string dniArgentino = "123456";
			try
			{
				Profesor profesor = new Profesor(0, "Nombre", "Apellido", dniArgentino, Persona.ENacionalidad.Extranjero);
			}
			catch (Exception exception)
			{
				Assert.IsInstanceOfType(exception, typeof(NacionalidadInvalidaException));
				return;
			}
			Assert.Fail("No lanza excepción para Dni {0}.", dniArgentino);
		}

		[TestMethod]
		public void InstanciarProfesorArgentinoConDniExtranjero_LanzaExcepcionNacionalidadInvalidaException()
		{
			const string dniExtranjero = "90000000";
			try
			{
				Profesor profesor = new Profesor(0, "Nombre", "Apellido", dniExtranjero, Persona.ENacionalidad.Argentino);
			}
			catch (Exception exception)
			{
				Assert.IsInstanceOfType(exception, typeof(NacionalidadInvalidaException));
				return;
			}
			Assert.Fail("No lanza excepción para Dni {0}.", dniExtranjero);
		}

		[TestMethod]
		public void InstanciarProfesorArgentinoDniValido_SeCargaCorrectamenteElDni()
		{
			const string dniValido = "123456";
			int dniCargado;
			Profesor profesor = new Profesor(0, "Nombre", "Apellido", dniValido, Persona.ENacionalidad.Argentino);

			dniCargado = profesor.DNI;

			Assert.AreEqual(dniValido, dniCargado.ToString());
		}

		[TestMethod]
		public void InstanciarProfesorExtranjeroDniValido_SeCargaCorrectamenteElDni()
		{
			const string dniValido = "90000000";
			int dniCargado;
			Profesor profesor = new Profesor(0, "Nombre", "Apellido", dniValido, Persona.ENacionalidad.Extranjero);

			dniCargado = profesor.DNI;

			Assert.AreEqual(dniValido, dniCargado.ToString());
		}

		[TestMethod]
		public void ProfesorToString_NoDevuelveStringVacio()
		{
			string retorno;
			Profesor profesor = new Profesor(0, "Nombre", "Apellido", "123456", Persona.ENacionalidad.Argentino);

			retorno = profesor.ToString();

			Assert.AreNotEqual("", retorno);
		}
	}
}
