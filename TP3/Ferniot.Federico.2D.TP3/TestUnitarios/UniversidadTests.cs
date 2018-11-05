using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClasesInstanciables;
using ClasesAbstractas;
using Excepciones;
using System.Collections.Generic;

namespace TestUnitarios
{
	[TestClass]
	public class UniversidadTests
	{
		[TestMethod]
		public void AccederAJornadaATravesDeIndice_DevuelveJornada()
		{
			Profesor profesor = new Profesor(0, "Nombre", "Apellido", "123456", ClasesAbstractas.Persona.ENacionalidad.Argentino);
			Universidad universidad = new Universidad();
			List<Jornada> jornadas = new List<Jornada>();
			Jornada jornada = new Jornada(Universidad.EClases.Laboratorio, profesor);
			Jornada jornadaDevuelta;
			jornadas.Add(jornada);
			universidad.Jornadas = jornadas;

			jornadaDevuelta = universidad[0];

			Assert.AreEqual(jornada, jornadaDevuelta);
		}

		[TestMethod]
		public void AgregarAlumnoAUniversidad_SeAgregaAlumno()
		{
			Universidad universidad = new Universidad();
			Alumno alumno = new Alumno(0, "Nombre", "Apellido", "123456",
				ClasesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
			List<Alumno> alumnos;

			universidad += alumno;
			alumnos = universidad.Alumnos;

			Assert.AreEqual(alumno, alumnos[0]);
		}

		[TestMethod]
		public void AgregarMismoAlumnoDosVecesAUniversidad_LanzaExcepcionAlumnoRepetidoException()
		{
			Universidad universidad = new Universidad();
			Alumno alumno = new Alumno(0, "Nombre", "Apellido", "123456",
				ClasesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);

			try
			{
				universidad += alumno;
				universidad += alumno;
			}
			catch (Exception e)
			{
				Assert.IsInstanceOfType(e, typeof(AlumnoRepetidoException));
				return;
			}
			Assert.Fail("No se lanzó excepción");
		}

		[TestMethod]
		public void AgregarProfesorAUniversidad_SeAgregaProfesor()
		{
			Universidad universidad = new Universidad();
			Profesor profesor = new Profesor(0, "Nombre", "Apellido", "123456", Persona.ENacionalidad.Argentino);
			List<Profesor> profesores;

			universidad += profesor;
			profesores = universidad.Instructores;

			Assert.AreEqual(profesor, profesores[0]);
		}

		[TestMethod]
		public void IgualdadUniversidadConAlumnoAgregadoYMismoAlumno_DevuelveTrue()
		{
			bool resultado;
			Universidad universidad = new Universidad();
			Alumno alumno = new Alumno(0, "Nombre", "Apellido", "123456",
				ClasesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);

			universidad += alumno;
			resultado = universidad == alumno;

			Assert.IsTrue(resultado);
		}

		[TestMethod]
		public void IgualdadUniversidadSinAlumnoAgregadoYAlumno_DevuelveFalse()
		{
			bool resultado;
			Universidad universidad = new Universidad();
			Alumno alumno = new Alumno(0, "Nombre", "Apellido", "123456",
				ClasesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);

			resultado = universidad == alumno;

			Assert.IsFalse(resultado);
		}

		[TestMethod]
		public void IgualdadUniversidadConProfesorAgregadoYMismoProfesor_DevuelveTrue()
		{
			bool resultado;
			Universidad universidad = new Universidad();
			Profesor profesor = new Profesor(0, "Nombre", "Apellido", "123456", Persona.ENacionalidad.Argentino);

			universidad += profesor;
			resultado = universidad == profesor;

			Assert.IsTrue(resultado);
		}

		[TestMethod]
		public void IgualdadUniversidadSinProfesorAgregadoYProfesor_DevuelveFalse()
		{
			bool resultado;
			Universidad universidad = new Universidad();
			Profesor profesor = new Profesor(0, "Nombre", "Apellido", "123456", Persona.ENacionalidad.Argentino);

			resultado = universidad == profesor;

			Assert.IsFalse(resultado);
		}

		[TestMethod]
		public void IgualdadUniversidadSinProfesorYClase_LanzaExcepcionSinProfesorExcepction()
		{
			Universidad universidad = new Universidad();
			Universidad.EClases clase = Universidad.EClases.Laboratorio;
			Profesor profesor;

			try
			{
				profesor = universidad == clase;
			}
			catch (Exception e)
			{
				Assert.IsInstanceOfType(e, typeof(SinProfesorException));
				return;
			}
			Assert.Fail("No se lanzó la excepción");
		}

		[TestMethod]
		public void DesigualdadUniversidadSinProfesorYClase_LanzaExcepcionSinProfesorExcepction()
		{
			Universidad universidad = new Universidad();
			Universidad.EClases clase = Universidad.EClases.Laboratorio;
			Profesor profesor;

			try
			{
				profesor = universidad != clase;
			}
			catch (Exception e)
			{
				Assert.IsInstanceOfType(e, typeof(SinProfesorException));
				return;
			}
			Assert.Fail("No se lanzó la excepción");
		}

		[TestMethod]
		public void AgregarClaseAUniversidadSinProfesor_LanzaExcepcionSinProfesorException()
		{
			Universidad universidad = new Universidad();
			Universidad.EClases clase = Universidad.EClases.Laboratorio;

			try
			{
				universidad += clase;
			}
			catch (Exception e)
			{
				Assert.IsInstanceOfType(e, typeof(SinProfesorException));
				return;
			}
			Assert.Fail("No se lanzó la excepción");
		}

		[TestMethod]
		public void UniversidadToString_NoDevuelveStringVacio()
		{
			string resultado;
			Universidad universidad = new Universidad();

			resultado = universidad.ToString();

			Assert.AreNotEqual("", resultado);
		}
	}
}
