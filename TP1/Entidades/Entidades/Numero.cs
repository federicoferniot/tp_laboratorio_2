using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        private string SetNumero
        {
            set
            {
                double resultado;
                resultado = ValidarNumero(value);
                numero = resultado;
            }
        }

		/// <summary>
		/// Inicializa una nueva instancia de la clase Numero con el número dado
		/// </summary>
		/// <param name="numero">Número que representa</param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

		/// <summary>
		/// Inicializa una nueva instancia de la clase Numero con el número dado
		/// </summary>
		/// <param name="numero">Número que representa</param>
		public Numero(string numero)
        {
            SetNumero = numero;
        }

		/// <summary>
		/// Resta dos números
		/// </summary>
		/// <param name="numeroUno">Primer número a restar</param>
		/// <param name="numeroDos">Segundo número a restar</param>
		/// <returns></returns>
        public static double operator -(Numero numeroUno, Numero numeroDos)
        {
            return numeroUno.numero - numeroDos.numero;
        }

		/// <summary>
		/// Suma dos números
		/// </summary>
		/// <param name="numeroUno">Primer número a sumar</param>
		/// <param name="numeroDos">Segundo número a sumar</param>
		/// <returns></returns>
        public static double operator +(Numero numeroUno, Numero numeroDos)
        {
            return numeroUno.numero + numeroDos.numero;
        }

		/// <summary>
		/// Divide dos números
		/// </summary>
		/// <param name="numeroUno">Número dividendo</param>
		/// <param name="numeroDos">Número divisor</param>
		/// <returns></returns>
        public static double operator /(Numero numeroUno, Numero numeroDos)
        {
            return numeroUno.numero / numeroDos.numero;
        }

		/// <summary>
		/// Multiplica dos números
		/// </summary>
		/// <param name="numeroUno">Primer número a multiplicar</param>
		/// <param name="numeroDos">Segundo número a multiplicar</param>
		/// <returns></returns>
        public static double operator *(Numero numeroUno, Numero numeroDos)
        {
            return numeroUno.numero * numeroDos.numero;
        }

		/// <summary>
		/// Valida el número dado como string y lo devuelve como double
		/// </summary>
		/// <param name="strNumero">Número a validar</param>
		/// <returns></returns>
        private double ValidarNumero(string strNumero)
        {
            double.TryParse(strNumero, out double resultado);
            return resultado;
        }

		public static implicit operator Numero(string numero)
		{
			return new Numero(numero);
		}

		public static implicit operator Numero(double numero)
		{
			return new Numero(numero);
		}

		/// <summary>
		/// Transforma un número binario a decimal y lo devuelve como string
		/// </summary>
		/// <param name="binario">Número binario a transformar</param>
		/// <returns></returns>
        public static string BinarioDecimal(string binario)
        {
			if (Regex.IsMatch(binario, "^[01]+$"))
			{
				int exponencia = (int)Math.Pow(2, binario.Length - 1);
				double acumulador = 0;
				foreach (char caracter in binario)
				{
					acumulador += ((int)Char.GetNumericValue(caracter) * exponencia);
					exponencia /= 2;
				}
				return acumulador.ToString();
			}
			return "Valor invalido";
        }

		/// <summary>
		/// Transforma un número decimal a Binario
		/// </summary>
		/// <param name="numero">Número decimal a transformar</param>
		/// <returns></returns>
        public static string DecimalBinario(double numero)
        {
			if (numero >= 0)
			{
				string binario = "";
				if (numero == 0)
				{
					binario = "0";
				}
				while (numero != 0)
				{
					binario = String.Concat((numero % 2).ToString(), binario);
					numero = (int)numero / 2;
				}
				return binario;
			}
			return "Valor invalido";
		}

		/// <summary>
		/// Transforma un número decimal a binario
		/// </summary>
		/// <param name="numero">Número decimal a transformar</param>
		/// <returns></returns>
        public static string DecimalBinario(string numero)
        {
			if (double.TryParse(numero, out double doubleNumero))
			{
				return DecimalBinario(doubleNumero);
			}
			return "Valor invalido";
        }
    }
}
