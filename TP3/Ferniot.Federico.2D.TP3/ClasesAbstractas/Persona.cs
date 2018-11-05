using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.Text.RegularExpressions;

namespace ClasesAbstractas
{
    public abstract class Persona
    {
		public enum ENacionalidad
		{
			Argentino,
			Extranjero
		}

		private int dni;
		private string apellido;
		private string nombre;
		private ENacionalidad nacionalidad;

		#region Propiedades
		/// <summary>
		/// Setea o devuelve el Apellido de la persona
		/// </summary>
		public string Apellido
		{
			get
			{
				return this.apellido;
			}
			set
			{
				this.apellido = ValidarNombreApellido(value);
			}
		}
		/// <summary>
		/// Setea o devuelve el Nombre de la persona
		/// </summary>
		public string Nombre
		{
			get
			{
				return this.nombre;
			}
			set
			{
				this.nombre = ValidarNombreApellido(value);
			}
		}
		/// <summary>
		/// Setea o devuelve el DNI de la persona
		/// </summary>
		public int DNI
		{
			get
			{
				return this.dni;
			}
			set
			{
				this.dni = this.ValidarDni(this.Nacionalidad, value);
			}
		}
		/// <summary>
		/// Setea o devuelve la Nacionalidad de la persona
		/// </summary>
		public ENacionalidad Nacionalidad
		{
			get
			{
				return this.nacionalidad;
			}
			set
			{
				this.nacionalidad = value;
			}
		}
		/// <summary>
		/// Setea el DNI pasado como string
		/// </summary>
		public string StringToDNI
		{
			set
			{
				this.dni = this.ValidarDni(this.Nacionalidad, value);
			}
		}

		#endregion

		#region Constructores
		/// <summary>
		/// Constructor de persona con datos por defecto
		/// </summary>
		public Persona(): this("", "", default(ENacionalidad))
		{
			this.dni = 0;
		}
		/// <summary>
		/// Constructor de persona con Nombre, Apellido y Nacionalidad dados
		/// </summary>
		/// <param name="nombre"></param>
		/// <param name="apellido"></param>
		/// <param name="nacionalidad"></param>
		public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
		{
			this.Nombre = nombre;
			this.Apellido = apellido;
			this.Nacionalidad = nacionalidad;
		}
		/// <summary>
		/// Constructor de persona con Nombre, Apellido, DNI y Nacionalidad dados
		/// </summary>
		/// <param name="nombre"></param>
		/// <param name="apellido"></param>
		/// <param name="dni"></param>
		/// <param name="nacionalidad"></param>
		public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad): this(nombre, apellido, nacionalidad)
		{
			this.DNI = dni;
		}
		/// <summary>
		/// Constructor de persona con Nombre, Apellido, DNI y Nacionalidad dados
		/// </summary>
		/// <param name="nombre"></param>
		/// <param name="apellido"></param>
		/// <param name="dni"></param>
		/// <param name="nacionalidad"></param>
		public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
		{
			this.StringToDNI = dni;
		}

		#endregion

		#region Métodos
		/// <summary>
		/// Devuelve los datos de la persona
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("NOMBRE COMPLETO: {0}, {1}\r\n", this.Apellido, this.Nombre);
			sb.AppendFormat("NACIONALIDAD: {0}\r\n\n", this.Nacionalidad.ToString());

			return sb.ToString();
		}
		/// <summary>
		/// Valida el dni según la nacionalidad
		/// </summary>
		/// <param name="nacionalidad"></param>
		/// <param name="dato"></param>
		/// <returns></returns>
		private int ValidarDni(ENacionalidad nacionalidad, int dato)
		{
			switch (nacionalidad)
			{
				case ENacionalidad.Argentino:
					if (dato >= 1 && dato <= 89999999)
						return dato;
					break;
				case ENacionalidad.Extranjero:
					if (dato >= 90000000 && dato <= 99999999)
						return dato;
					break;
			}
			throw new NacionalidadInvalidaException();
		}
		/// <summary>
		/// Valida el dni como string según la nacionalidad
		/// </summary>
		/// <param name="nacionalidad"></param>
		/// <param name="dato"></param>
		/// <returns></returns>
		private int ValidarDni(ENacionalidad nacionalidad, string dato)
		{
			if (int.TryParse(dato, out int dni))
			{
				return this.ValidarDni(nacionalidad, dni);
			}
			throw new DniInvalidoException();
		}
		/// <summary>
		/// Valida que el nombre o apellido tengan caracteres válidos
		/// </summary>
		/// <param name="dato"></param>
		/// <returns></returns>
		private string ValidarNombreApellido(string dato)
		{
			string patron = "^[\\p{L}]+$";
			if (Regex.IsMatch(dato, patron))
				return dato;
			return "";
		}

		#endregion
	}
}
