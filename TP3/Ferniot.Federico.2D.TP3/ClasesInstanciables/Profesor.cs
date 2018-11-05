using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace ClasesInstanciables
{
	public sealed class Profesor: Universitario
	{
		private Queue<Universidad.EClases> clasesDelDia;
		private static Random random;

		#region Constructores
		/// <summary>
		/// Se instancia random para calcular clases del día del profesor
		/// </summary>
		static Profesor()
		{
			random = new Random();
		}
		/// <summary>
		/// Crea una nueva instancia de profesor con datos por defecto
		/// </summary>
		public Profesor(): base()
		{

		}
		/// <summary>
		/// Crea una nueva instancia de profesor con Id, nombre, apellido, dni y nacionalidad dados
		/// </summary>
		/// <param name="id"></param>
		/// <param name="nombre"></param>
		/// <param name="apellido"></param>
		/// <param name="dni"></param>
		/// <param name="nacionalidad"></param>
		public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad): 
			base(id, nombre, apellido, dni, nacionalidad)
		{
			this.clasesDelDia = new Queue<Universidad.EClases>();
			this.RandomClases();
		}

		#endregion

		#region Métodos

		/// <summary>
		/// Devuelve los datos del profesor
		/// </summary>
		/// <returns></returns>
		protected override string MostrarDatos()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append(base.MostrarDatos());
			sb.Append(this.ParticiparEnClase());

			return sb.ToString();
		}
		/// <summary>
		/// Devuelve las información de las clases en las que participa el profesor
		/// </summary>
		/// <returns></returns>
		protected override string ParticiparEnClase()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine("CLASES DEL DIA:");
			foreach (Universidad.EClases clase in this.clasesDelDia)
			{
				sb.AppendLine(clase.ToString());
			}

			return sb.ToString();
		}

		/// <summary>
		/// Setea dos clases random a las clases del profesor
		/// </summary>
		private void RandomClases()
		{
			for (int i = 0; i < 2; i++)
			{
				this.clasesDelDia.Enqueue((Universidad.EClases)Profesor.random.Next(0, 3));
			}
		}
		/// <summary>
		/// Devuelve la información del profesor
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return this.MostrarDatos();
		}

		#endregion

		#region Operadores
		/// <summary>
		/// Si la clase es una de las clases del día del profesor, devuelve True. Sino False
		/// </summary>
		/// <param name="instructor"></param>
		/// <param name="clase"></param>
		/// <returns></returns>
		public static bool operator ==(Profesor instructor, Universidad.EClases clase)
		{
			foreach (Universidad.EClases claseDelProfesor in instructor.clasesDelDia)
			{
				if (claseDelProfesor == clase)
					return true;
			}
			return false;
		}
		/// <summary>
		/// Si la clase es una de las clases del día del profesor, devuelve False. Sino True
		/// </summary>
		/// <param name="instructor"></param>
		/// <param name="clase"></param>
		/// <returns></returns>
		public static bool operator !=(Profesor instructor, Universidad.EClases clase)
		{
			return !(instructor == clase);
		}

		#endregion
	}
}
