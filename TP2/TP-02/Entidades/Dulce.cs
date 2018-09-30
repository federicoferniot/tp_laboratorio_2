using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Dulce : Producto
    {

		/// <summary>
		/// Inicializa una nueva instancia de la clase Dulce con los valores dados
		/// </summary>
		/// <param name="marca">Marca del dulce</param>
		/// <param name="patente">Codigo de barras</param>
		/// <param name="color">Color del empaque</param>
		public Dulce(EMarca marca, string patente, ConsoleColor color)
			: base(patente, marca, color)
        {
        }

        /// <summary>
        /// Los dulces tienen 80 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 80;
            }
        }

		/// <summary>
		/// Muestra los datos del dulce
		/// </summary>
		/// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DULCE");
            sb.AppendLine((string)this);
            sb.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
