using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
		/// <summary>
		/// Realiza la operación dada entre los dos números
		/// </summary>
		/// <param name="numeroUno">Primer número para la operación</param>
		/// <param name="numeroDos">Segundo número para la operación</param>
		/// <param name="operador">Operador</param>
		/// <returns></returns>
        public static double Operar(Numero numeroUno, Numero numeroDos, string operador)
        {
            double resultado=0;
            operador = ValidarOperador(operador);
            switch(operador)
            {
                case "+":
                    resultado = numeroUno + numeroDos;
                    break;
                case "-":
                    resultado = numeroUno - numeroDos;
                    break;
                case "/":
                    resultado = numeroUno / numeroDos;
                    break;
                case "*":
                    resultado = numeroUno * numeroDos;
                    break;
            }
            return resultado;
        }

		/// <summary>
		/// Valida que el operador sea correcto, sino devuelve ["+"]
		/// </summary>
		/// <param name="operador">Operador a validar</param>
		/// <returns></returns>
        private static string ValidarOperador(string operador)
        {
            if(operador == "+" || operador == "-" || operador == "/" || operador == "*")
            {
                return operador;
            }
            return "+";
        }
    }
}
