using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades_2018
{
    public class Leche : Producto
    {
        public enum ETipo
		{
			Entera, Descremada
		}
        ETipo tipo;

        /// <summary>
        /// Por defecto, TIPO será ENTERA
        /// </summary>
        /// <param name="marca">Marca de la leche</param>
        /// <param name="patente">Codigo de barras</param>
        /// <param name="color">Color del empaque</param>
        public Leche(EMarca marca, string patente, ConsoleColor color)
            : base(patente, marca, color)
        {
			this.tipo = ETipo.Entera;
        }

		/// <summary>
		/// Inicializa una nueva instancia de la clase Leche con los valores dados
		/// </summary>
		/// <param name="marca">Marca de la leche</param>
		/// <param name="patente">Código de barras</param>
		/// <param name="color">Color del empaque</param>
		/// <param name="tipo">Tipo de leche</param>
		public Leche(EMarca marca, string patente, ConsoleColor color, ETipo tipo)
			: base(patente, marca, color)
		{
			this.tipo = tipo;
		}

		/// <summary>
		/// Las leches tienen 20 calorías
		/// </summary>
		protected override short CantidadCalorias
        {
            get
            {
                return 20;
            }
        }

		/// <summary>
		/// Muestra los datos de la Leche
		/// </summary>
		/// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LECHE");
            sb.AppendLine((string)this);
            sb.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
