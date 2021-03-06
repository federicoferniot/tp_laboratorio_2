﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    /// <summary>
    /// La clase Producto no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Producto
    {
        public enum EMarca
        {
            Serenisima, Campagnola, Arcor, Ilolay, Sancor, Pepsico
        }
        private EMarca marca;
        private string codigoDeBarras;
        private ConsoleColor colorPrimarioEmpaque;

        /// <summary>
        /// ReadOnly: Retornará la cantidad de calorias del producto
        /// </summary>
        protected abstract short CantidadCalorias { get;}

		public Producto(string patente, EMarca marca, ConsoleColor color)
		{
			this.codigoDeBarras = patente;
			this.marca = marca;
			this.colorPrimarioEmpaque = color;
		}

		/// <summary>
		/// Publica todos los datos del Producto.
		/// </summary>
		/// <returns></returns>
		public abstract string Mostrar();

        public static explicit operator string(Producto producto)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CODIGO DE BARRAS: {0}\r\n", producto.codigoDeBarras);
            sb.AppendFormat("MARCA          : {0}\r\n", producto.marca.ToString());
            sb.AppendFormat("COLOR EMPAQUE  : {0}\r\n", producto.colorPrimarioEmpaque.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos productos son iguales si comparten el mismo código de barras
        /// </summary>
        /// <param name="productoUno"></param>
        /// <param name="productoDos"></param>
        /// <returns></returns>
        public static bool operator ==(Producto productoUno, Producto productoDos)
        {
            return (productoUno.codigoDeBarras == productoDos.codigoDeBarras);
        }
        /// <summary>
        /// Dos productos son distintos si su código de barras es distinto
        /// </summary>
        /// <param name="productoUno"></param>
        /// <param name="productoDos"></param>
        /// <returns></returns>
        public static bool operator !=(Producto productoUno, Producto productoDos)
        {
            return !(productoUno.codigoDeBarras == productoDos.codigoDeBarras);
        }
    }
}
