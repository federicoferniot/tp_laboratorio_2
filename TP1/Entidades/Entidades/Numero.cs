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

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string numero)
        {
            SetNumero = numero;
        }

        public static double operator -(Numero numeroUno, Numero numeroDos)
        {
            return numeroUno.numero - numeroDos.numero;
        }

        public static double operator +(Numero numeroUno, Numero numeroDos)
        {
            return numeroUno.numero + numeroDos.numero;
        }

        public static double operator /(Numero numeroUno, Numero numeroDos)
        {
            return numeroUno.numero / numeroDos.numero;
        }

        public static double operator *(Numero numeroUno, Numero numeroDos)
        {
            return numeroUno.numero * numeroDos.numero;
        }

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
