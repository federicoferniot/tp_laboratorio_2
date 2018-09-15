using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
		bool resultadoEsBinario;

        public LaCalculadora()
        {
            InitializeComponent();
			resultadoEsBinario = false;
        }

		private void LaCalculadora_Load(object sender, EventArgs e)
		{
			CenterToScreen();
		}

		private void btnOperar_Click(object sender, EventArgs e)
		{
			lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
			resultadoEsBinario = false;
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			Limpiar();
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		private void btnConvertirABinario_Click(object sender, EventArgs e)
		{
			if (!(lblResultado.Text == "") && !resultadoEsBinario)
			{
				lblResultado.Text = Entidades.Numero.DecimalBinario(lblResultado.Text);
				resultadoEsBinario = true;
			}
		}

		private void btnConvertirADecimal_Click(object sender, EventArgs e)
		{
			if (!(lblResultado.Text == "") && resultadoEsBinario)
			{
				lblResultado.Text = Entidades.Numero.BinarioDecimal(lblResultado.Text);
				resultadoEsBinario = false;
			}
		}

		/// <summary>
		/// Realiza la operación correspondiente entre los dos números
		/// </summary>
		/// <param name="numero1">Primer número para realizar la operación</param>
		/// <param name="numero2">Segundo número para realizar la operación</param>
		/// <param name="operador">Operador para realizar la operación</param>
		/// <returns></returns>
		private static double Operar(string numero1, string numero2, string operador)
		{
			return Entidades.Calculadora.Operar(numero1, numero2, operador);
		}

		/// <summary>
		/// Limpia la calculadora de resultados y números ingresados
		/// </summary>
		private void Limpiar()
		{
			txtNumero1.Clear();
			txtNumero2.Clear();
			cmbOperador.SelectedIndex = -1;
			lblResultado.ResetText();
		}

	}
}
