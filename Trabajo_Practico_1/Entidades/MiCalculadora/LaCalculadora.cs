using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
        public LaCalculadora()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = LaCalculadora.Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text).ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero n1 = new Numero();

            lblResultado.Text = n1.BinarioDecimal(this.lblResultado.Text);
        }

        private void btnDecimalABinario_Click(object sender, EventArgs e)
        {
            Numero n1 = new Numero();

            lblResultado.Text = n1.DecimalBinario(this.lblResultado.Text);
        }

        #region "Métodos"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns>double</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero n1 = new Numero(numero1);
            Numero n2 = new Numero(numero2);

            Calculadora calc = new Calculadora();
            return calc.Operar(n1, n2, operador);
        }

        /// <summary>
        /// Borrará los datos de los TextBox, ComboBox y Label de la pantalla.
        /// </summary>
        private void Limpiar() {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.SelectedItem = null;
            this.lblResultado.Text = "";
        }
        #endregion
    }
}
