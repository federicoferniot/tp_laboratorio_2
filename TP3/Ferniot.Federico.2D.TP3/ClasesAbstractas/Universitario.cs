using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
	public abstract class Universitario: Persona
	{
		private int legajo;

		#region Constructores
		/// <summary>
		/// Constructor de universitario por defecto
		/// </summary>
		public Universitario(): base()
		{
			this.legajo = 0;
		}
		/// <summary>
		/// Constructor de universitario con Legajo, Nombre, Apellido, Dni y Nacionalidad dados
		/// </summary>
		/// <param name="legajo"></param>
		/// <param name="nombre"></param>
		/// <param name="apellido"></param>
		/// <param name="dni"></param>
		/// <param name="nacionalidad"></param>
		public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad):
			base(nombre, apellido, dni, nacionalidad)
		{
			this.legajo = legajo;
		}

		#endregion

		#region Métodos
		/// <summary>
		/// Devuelve los datos de universitario
		/// </summary>
		/// <returns></returns>
		protected virtual string MostrarDatos()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(base.ToString());
			sb.AppendFormat("LEGAJO NÚMERO: {0}\r\n", this.legajo);
			return sb.ToString();
		}

		protected abstract string ParticiparEnClase();

		public override bool Equals(object obj)
		{
			return this.GetType() == obj.GetType();
		}

		#endregion

		#region Operadores
		/// <summary>
		/// Si el legajo o dni de los universitarios son iguales, devuelve True. Sino False
		/// </summary>
		/// <param name="universitarioUno"></param>
		/// <param name="universitarioDos"></param>
		/// <returns></returns>
		public static bool operator ==(Universitario universitarioUno, Universitario universitarioDos)
		{
			return (universitarioUno.Equals(universitarioDos) &&
				(universitarioUno.legajo == universitarioDos.legajo || universitarioUno.DNI == universitarioDos.DNI));
		}
		/// <summary>
		/// Si el legajo y dni de los universitarios son distintos, devuelve True. Sino False
		/// </summary>
		/// <param name="universitarioUno"></param>
		/// <param name="universitarioDos"></param>
		/// <returns></returns>
		public static bool operator !=(Universitario universitarioUno, Universitario universitarioDos)
		{
			return !(universitarioUno == universitarioDos);
		}

		#endregion
	}
}
