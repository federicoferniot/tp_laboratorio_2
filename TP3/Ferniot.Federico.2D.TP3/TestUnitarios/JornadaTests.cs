using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClasesAbstractas;
using ClasesInstanciables;
using Excepciones;
using System.Collections.Generic;

namespace TestUnitarios
{
	[TestClass]
	public class JornadaTests
	{
		[TestMethod]
		public void InstanciarJornada_ListaDeAlumnosNoEsNull()
		{
			Profesor profesor = new Profesor();
			Jornada jornada = new Jornada(Universidad.EClases.Laboratorio, profesor);
			List<Alumno> alumnos;

			alumnos = jornada.Alumnos;

			Assert.IsNotNull(alumnos);
		}

		[TestMethod]
		public void AgregarAlumnoAJornada_SeAgregaCorrectamenteAlumno()
		{
			Profesor profesor = new Profesor();
			Jornada jornada = new Jornada(Universidad.EClases.Laboratorio, profesor);
			Alumno alumno = new Alumno();
			List<Alumno> alumnos;

			jornada += alumno;
			alumnos = jornada.Alumnos;

			Assert.AreEqual(alumno, alumnos[0]);
		}

		[TestMethod]
		public void AgregarDosVecesMismoAlumno_LanzaExcepcionAlumnoRepetidoException()
		{
			Profesor profesor = new Profesor();
			Jornada jornada = new Jornada(Universidad.EClases.Laboratorio, profesor);
			Alumno alumno = new Alumno(1, "Nombre", "Apellido", "123456",
				Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);

			try
			{
				jornada += alumno;
				jornada += alumno;
			}
			catch (Exception e)
			{
				Assert.IsInstanceOfType(e, typeof(AlumnoRepetidoException));
				return;
			}
			Assert.Fail("No se lanzó excepción");
		}

		[TestMethod]
		public void IgualdadJornadaConAlumnoYMismoAlumno_DevuelveTrue()
		{
			bool resultado;
			Profesor profesor = new Profesor();
			Jornada jornada = new Jornada(Universidad.EClases.Laboratorio, profesor);
			Alumno alumno = new Alumno(1, "Nombre", "Apellido", "123456",
				Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);

			jornada += alumno;
			resultado = jornada == alumno;

			Assert.IsTrue(resultado);
		}

		[TestMethod]
		public void IgualdadJornadaYAlumnoQueNoPertenezca_DevuelveFalse()
		{
			bool resultado;
			Profesor profesor = new Profesor();
			Jornada jornada = new Jornada(Universidad.EClases.Laboratorio, profesor);
			Alumno alumno = new Alumno(1, "Nombre", "Apellido", "123456",
				Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);

			resultado = jornada == alumno;

			Assert.IsFalse(resultado);
		}

		[TestMethod]
		public void JornadaToString_NoDevuelveStringVacio()
		{
			string resultado;
			Profesor profesor = new Profesor(0, "Nombre", "Apellido", "123456", Persona.ENacionalidad.Argentino);
			Jornada jornada = new Jornada(Universidad.EClases.Laboratorio, profesor);

			resultado = jornada.ToString();

			Assert.AreNotEqual("", resultado);
		}
	}
}
