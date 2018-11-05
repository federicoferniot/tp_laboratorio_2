using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClasesInstanciables;
using ClasesAbstractas;
using Excepciones;

namespace TestUnitarios
{
	[TestClass]
	public class AlumnoTests
	{
		[TestMethod]
		public void InstanciarAlumnoConDniCaracteresInvalidos_LanzaExcepcionDniInvalidoException()
		{
			const string dniInvalido = "Invalido";
			try
			{
				Alumno alumno = new Alumno(1, "Nombre", "Apellido", dniInvalido,
					Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
			}
			catch (Exception exception)
			{
				Assert.IsInstanceOfType(exception, typeof(DniInvalidoException));
				return;
			}
			Assert.Fail("No lanza excepción para Dni {0}.", dniInvalido);
		}

		[TestMethod]
		public void InstanciarAlumnoExtranjeroConDniArgentino_LanzaExcepcionNacionalidadInvalidaException()
		{
			const string dniArgentino = "123456";
			try
			{
				Alumno alumno = new Alumno(1, "Nombre", "Apellido", dniArgentino,
					Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
			}
			catch (Exception exception)
			{
				Assert.IsInstanceOfType(exception, typeof(NacionalidadInvalidaException));
				return;
			}
			Assert.Fail("No lanza excepción para Dni {0}.", dniArgentino);
		}

		[TestMethod]
		public void InstanciarAlumnoArgentinoConDniExtranjero_LanzaExcepcionNacionalidadInvalidaException()
		{
			const string dniExtranjero = "90000000";
			try
			{
				Alumno alumno = new Alumno(1, "Nombre", "Apellido", dniExtranjero,
					Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
			}
			catch (Exception exception)
			{
				Assert.IsInstanceOfType(exception, typeof(NacionalidadInvalidaException));
				return;
			}
			Assert.Fail("No lanza excepción para Dni {0}.", dniExtranjero);
		}

		[TestMethod]
		public void InstanciarAlumnoArgentinoDniValido_SeCargaCorrectamenteElDni()
		{
			const string dniValido = "123456";
			int dniCargado;
			Alumno alumno = new Alumno(1, "Nombre", "Apellido", dniValido,
				Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);

			dniCargado = alumno.DNI;

			Assert.AreEqual(dniValido, dniCargado.ToString());
		}

		[TestMethod]
		public void InstanciarAlumnoExtranjeroDniValido_SeCargaCorrectamenteElDni()
		{
			const string dniValido = "90000000";
			int dniCargado;
			Alumno alumno = new Alumno(1, "Nombre", "Apellido", dniValido,
				Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);

			dniCargado = alumno.DNI;

			Assert.AreEqual(dniValido, dniCargado.ToString());
		}

		[TestMethod]
		public void IgualdadAlumnoConDeudaEnClaseYClase_DevuelveFalse()
		{
			bool retorno;
			Universidad.EClases clase = Universidad.EClases.Laboratorio;
			Alumno alumno = new Alumno(1, "Nombre", "Apellido", "123456",
				Persona.ENacionalidad.Argentino, clase, Alumno.EEstadoCuenta.Deudor);

			retorno = alumno == clase;

			Assert.IsFalse(retorno);
		}

		[TestMethod]
		public void IgualdadAlumnoAlDiaQueNoEsteEnClaseYClase_DevuelveFlase()
		{
			bool retorno;
			Universidad.EClases clase = Universidad.EClases.Laboratorio;
			Universidad.EClases claseAlumno = Universidad.EClases.Legislacion;
			Alumno alumno = new Alumno(1, "Nombre", "Apellido", "123456",
				Persona.ENacionalidad.Argentino, claseAlumno, Alumno.EEstadoCuenta.AlDia);

			retorno = alumno == clase;

			Assert.IsFalse(retorno);
		}

		[TestMethod]
		public void IgualdadAlumnoAlDiaEnClaseYClase_DevuelveTrue()
		{
			bool retorno;
			Universidad.EClases clase = Universidad.EClases.Laboratorio;
			Alumno alumno = new Alumno(1, "Nombre", "Apellido", "123456",
				Persona.ENacionalidad.Argentino, clase, Alumno.EEstadoCuenta.AlDia);

			retorno = alumno == clase;

			Assert.IsTrue(retorno);
		}

		[TestMethod]
		public void AlumnoToString_NoDevuelveStringVacio()
		{
			string retorno;
			Alumno alumno = new Alumno(1, "Nombre", "Apellido", "123456",
				Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);

			retorno = alumno.ToString();

			Assert.AreNotEqual("", retorno);
		}
	}
}
