using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;
using Archivos;

namespace ClasesInstanciables
{
	public class Universidad
	{
		public enum EClases
		{
			Programacion,
			Laboratorio,
			Legislacion,
			SPD
		}

		private List<Alumno> alumnos;
		private List<Jornada> jornada;
		private List<Profesor> profesores;

		#region Propiedades

		/// <summary>
		/// Setea o devuelve la lista de alumnos de la Universidad
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
		/// Setea o devuelve la lista de profesores de la Universidad
		/// </summary>
		public List<Profesor> Instructores
		{
			get
			{
				return this.profesores;
			}
			set
			{
				this.profesores = value;
			}
		}

		/// <summary>
		/// Setea o devuelve la lista de Jornadas de la Universidad
		/// </summary>
		public List<Jornada> Jornadas
		{
			get
			{
				return this.jornada;
			}
			set
			{
				this.jornada = value;
			}
		}

		/// <summary>
		/// Permite setear o devolver una Jornada de la Universiddad correspondiente al índice
		/// </summary>
		/// <param name="i">Indice de la Jornada</param>
		/// <returns></returns>
		public Jornada this[int i]
		{
			get
			{
				return this.jornada[i];
			}
			set
			{
				this.jornada[i] = value;
			}
		}

		#endregion

		#region Constructor

		/// <summary>
		/// Crea una nueva instancia de Universidad
		/// </summary>
		public Universidad()
		{
			this.alumnos = new List<Alumno>();
			this.jornada = new List<Jornada>();
			this.profesores = new List<Profesor>();
		}

		#endregion

		#region Métodos

		/// <summary>
		/// Guarda los datos de una Universidad en un archivo XML
		/// </summary>
		/// <param name="universidad">Universidad a guardar</param>
		/// <returns></returns>
		public static bool Guardar(Universidad universidad)
		{
			Xml<Universidad> xml = new Xml<Universidad>();
			return(xml.Guardar("Universidad.xml", universidad));
		}

		/// <summary>
		/// Devuelve los datos de la Universidad
		/// </summary>
		/// <param name="universidad"></param>
		/// <returns></returns>
		private string MostrarDatos(Universidad universidad)
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("JORNADA:");
			foreach (Jornada jornada in universidad.jornada)
			{
				sb.AppendLine(jornada.ToString());
				sb.AppendLine("<--------------------------------->\n");
			}
			return sb.ToString();
		}

		/// <summary>
		/// Devuelve los datos de la universidad
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return MostrarDatos(this);
		}

		#endregion

		#region Operadores
		/// <summary>
		/// Si el alumno se encuentra en la universidad devuelve True, sino False
		/// </summary>
		/// <param name="universidad"></param>
		/// <param name="alumno"></param>
		/// <returns></returns>
		public static bool operator ==(Universidad universidad, Alumno alumno)
		{
			foreach (Alumno alumnoEnUniversidad in universidad.alumnos)
			{
				if (alumnoEnUniversidad == alumno)
					return true;
			}
			return false;
		}
		/// <summary>
		/// Si el alumno no se encuentra en la universidad devuelve True, sino False
		/// </summary>
		/// <param name="universidad"></param>
		/// <param name="alumno"></param>
		/// <returns></returns>
		public static bool operator !=(Universidad universidad, Alumno alumno)
		{
			return !(universidad == alumno);
		}
		/// <summary>
		/// Si el instructor pertenece a la universidad devuelve True, sino False
		/// </summary>
		/// <param name="universidad"></param>
		/// <param name="instructor"></param>
		/// <returns></returns>
		public static bool operator ==(Universidad universidad, Profesor instructor)
		{
			foreach (Profesor profesor in universidad.profesores)
			{
				if (profesor == instructor)
					return true;
			}
			return false;
		}
		/// <summary>
		/// Si el instructor no pertenece a la universidad devuelve True, sino False
		/// </summary>
		/// <param name="universidad"></param>
		/// <param name="instructor"></param>
		/// <returns></returns>
		public static bool operator !=(Universidad universidad, Profesor instructor)
		{
			return !(universidad == instructor);
		}
		/// <summary>
		/// Devuelve el primer Profesor de la universidad que pueda dar la clase
		/// </summary>
		/// <param name="universidad"></param>
		/// <param name="clase"></param>
		/// <exception cref="SinProfesorException">Se lanza si no se encuentra profesor para esa clase</exception>
		/// <returns></returns>
		public static Profesor operator ==(Universidad universidad, EClases clase)
		{
			foreach (Profesor profesor in universidad.profesores)
			{
				if (profesor == clase)
					return profesor;
			}
			throw new SinProfesorException();
		}
		/// <summary>
		/// Devuelve el primer profesor de la universidad que no pueda dar la clase
		/// </summary>
		/// <param name="universidad"></param>
		/// <param name="clase"></param>ç
		/// <exception cref="SinProfesorException">Se lanza si no se encuentra profesor</exception>
		/// <returns></returns>
		public static Profesor operator !=(Universidad universidad, EClases clase)
		{
			foreach (Profesor profesor in universidad.profesores)
			{
				if (profesor != clase)
					return profesor;
			}
			throw new SinProfesorException();
		}
		/// <summary>
		/// Se agrega una nueva jornada a la universidad para la clase indicada
		/// </summary>
		/// <param name="universidad"></param>
		/// <param name="clase"></param>
		/// <returns></returns>
		public static Universidad operator +(Universidad universidad, EClases clase)
		{
			Jornada nuevaJornada = new Jornada(clase, universidad == clase);
			foreach (Alumno alumno in universidad.alumnos)
			{
				if (alumno == clase)
					nuevaJornada += alumno;
			}
			universidad.jornada.Add(nuevaJornada);
			return universidad;
		}
		/// <summary>
		/// Se agrega el alumno a la universidad, si no se encuentra ya agregado
		/// </summary>
		/// <param name="universidad"></param>
		/// <param name="alumno"></param>
		/// <exception cref="AlumnoRepetidoException">Se lanza si el alumno ya se encuentra agregado</exception>
		/// <returns></returns>
		public static Universidad operator +(Universidad universidad, Alumno alumno)
		{
			if (universidad != alumno)
				universidad.alumnos.Add(alumno);
			else
				throw new AlumnoRepetidoException();
			return universidad;
		}
		/// <summary>
		/// Se agrega un instructor a la universidad
		/// </summary>
		/// <param name="universidad"></param>
		/// <param name="instructor"></param>
		/// <returns></returns>
		public static Universidad operator +(Universidad universidad, Profesor instructor)
		{
			if (universidad != instructor)
				universidad.profesores.Add(instructor);
			return universidad;
		}

		#endregion
	}
}
