using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Alumno: Universitario
    {
		public enum EEstadoCuenta
		{
			AlDia,
			Deudor,
			Becado
		}

		private Universidad.EClases claseQueToma;
		private EEstadoCuenta estadoCuenta;

		#region Constructores

		/// <summary>
		/// Crea una nueva instancia de Alumno con datos por defecto
		/// </summary>
		public Alumno(): base()
		{
			this.claseQueToma = default(Universidad.EClases);
			this.estadoCuenta = default(EEstadoCuenta);
		}
		/// <summary>
		/// Crea una nueva instancia de Alumno con Id, Nombre, Apellido, DNI, Nacionalidad y clase que toma
		/// </summary>
		/// <param name="id"></param>
		/// <param name="nombre"></param>
		/// <param name="apellido"></param>
		/// <param name="dni"></param>
		/// <param name="nacionalidad"></param>
		/// <param name="claseQueToma"></param>
		public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma): 
			base(id, nombre, apellido, dni, nacionalidad)
		{
			this.claseQueToma = claseQueToma;
		}
		/// <summary>
		/// Crea una nueva instancia de Alumno con Id, Nombre, Apellido, DNI, Nacionalidad, Clase que toma y Estado de la cuenta
		/// </summary>
		/// <param name="id"></param>
		/// <param name="nombre"></param>
		/// <param name="apellido"></param>
		/// <param name="dni"></param>
		/// <param name="nacionalidad"></param>
		/// <param name="claseQueToma"></param>
		/// <param name="estadoCuenta"></param>
		public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta):
			this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
		{
			this.estadoCuenta = estadoCuenta;
		}

		#endregion

		#region Métodos

		/// <summary>
		/// Devuelve la información del Alumno
		/// </summary>
		/// <returns></returns>
		protected override string MostrarDatos()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(base.MostrarDatos());
			sb.AppendFormat("ESTADO DE CUENTA: {0}\r\n", this.estadoCuenta.ToString());
			sb.AppendFormat(this.ParticiparEnClase());

			return sb.ToString();
		}
		/// <summary>
		/// Devuelve la información de la clase que toma el alumno
		/// </summary>
		/// <returns></returns>
		protected override string ParticiparEnClase()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("TOMA CLASE DE {0}", this.claseQueToma.ToString());
			return sb.ToString();
		}
		/// <summary>
		/// Devuelve la información del Alumno
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return this.MostrarDatos();
		}

		#endregion

		#region Operadores
		/// <summary>
		/// Si la clase es la clase que toma el alumno y su estado de cuenta no es Deudor, devuelve True. Sino False
		/// </summary>
		/// <param name="alumno"></param>
		/// <param name="clase"></param>
		/// <returns></returns>
		public static bool operator ==(Alumno alumno, Universidad.EClases clase)
		{
			return (alumno.claseQueToma == clase && alumno.estadoCuenta != EEstadoCuenta.Deudor);
		}
		/// <summary>
		/// Si la clase no es la que toma el alumno, devuelve True. Sino False
		/// </summary>
		/// <param name="alumno"></param>
		/// <param name="clase"></param>
		/// <returns></returns>
		public static bool operator !=(Alumno alumno, Universidad.EClases clase)
		{
			return alumno.claseQueToma != clase;
		}

		#endregion
	}
}
