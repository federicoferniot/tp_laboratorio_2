using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;

namespace ClasesInstanciables
{
	public class Jornada
	{
		private List<Alumno> alumnos;
		private Universidad.EClases clase;
		private Profesor instructor;

		#region Propiedades

		/// <summary>
		/// Setea o devuelve la lista de alumnos que corresponde a la jornada
		/// </summary>
		public List<Alumno> Alumnos
		{
			get
			{
				return this.alumnos;
			}
			set
			{
				this.alumnos = value;
			}
		}

		/// <summary>
		/// Setea o devuelve la clase de la jornada
		/// </summary>
		public Universidad.EClases Clase
		{
			get
			{
				return this.clase;
			}
			set
			{
				this.clase = value;
			}
		}

		/// <summary>
		/// Setea o devuelve el Instructor asignado a la clase de la jornada
		/// </summary>
		public Profesor Instructor
		{
			get
			{
				return this.instructor;
			}
			set
			{
				this.instructor = value;
			}
		}

		#endregion

		#region Constructores
		/// <summary>
		/// Se instancia la lista de alumnos de la jornada
		/// </summary>
		private Jornada()
		{
			this.alumnos = new List<Alumno>();
		}

		/// <summary>
		/// Crea una nueva instancia de Jornada con la clase e instructor indicados
		/// </summary>
		/// <param name="clase"></param>
		/// <param name="instructor"></param>
		public Jornada(Universidad.EClases clase, Profesor instructor): this()
		{
			this.Clase = clase;
			this.Instructor = instructor;
		}

		#endregion

		#region Métodos

		/// <summary>
		/// Guarda datos de la jornada en un archivo de texto
		/// </summary>
		/// <param name="jornada">Jornada a guardar</param>
		/// <returns></returns>
		public static bool Guardar(Jornada jornada)
		{
			Texto texto = new Texto();
			return(texto.Guardar("Jornada.txt", jornada.ToString()));
		}

		/// <summary>
		/// Levanta los datos de una jornada guardada y los devuelve
		/// </summary>
		/// <returns></returns>
		public string Leer()
		{
			string jornada="";
			Texto texto = new Texto();
			texto.Leer("Jornada.txt", out jornada);
			return jornada;
		}

		/// <summary>
		/// Devuelve los datos de la jornada
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendFormat("CLASE DE {0} ", this.clase.ToString());
			sb.AppendFormat("POR {0}\r\n", this.instructor.ToString());
			sb.AppendLine("ALUMNOS:");
			foreach (Alumno alumno in this.alumnos)
			{
				sb.AppendLine(alumno.ToString());
			}

			return sb.ToString();
		}

		#endregion

		#region Operadores
		/// <summary>
		/// Si el alumno se encuentra en la jornada devuelve True, sino False
		/// </summary>
		/// <param name="jornada"></param>
		/// <param name="alumno"></param>
		/// <returns></returns>
		public static bool operator ==(Jornada jornada, Alumno alumno)
		{
			foreach (Alumno alumnoEnJornada in jornada.alumnos)
			{
				if (alumnoEnJornada == alumno)
					return true;
			}
			return false;
		}
		/// <summary>
		/// Si el alumno no se encuentra en la jornada devuelve True, sino False
		/// </summary>
		/// <param name="jornada"></param>
		/// <param name="alumno"></param>
		/// <returns></returns>
		public static bool operator !=(Jornada jornada, Alumno alumno)
		{
			return !(jornada == alumno);
		}
		/// <summary>
		/// Agrega un alumno a la jornada si no se encuentra en la jornada
		/// </summary>
		/// <param name="jornada"></param>
		/// <param name="alumno"></param>
		/// <exception cref="AlumnoRepetidoException">Se lanza si el alumno ya se encuentra en la jornada</exception>
		/// <returns></returns>
		public static Jornada operator +(Jornada jornada, Alumno alumno)
		{
			if (jornada != alumno)
				jornada.alumnos.Add(alumno);
			else
				throw new AlumnoRepetidoException();
			return jornada;
		}

		#endregion
	}
}
