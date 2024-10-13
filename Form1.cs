using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNumero1.Text);
            double num2 = Convert.ToDouble(txtNumero2.Text);
            double resultado = num1 + num2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNumero1.Text);
            double num2 = Convert.ToDouble(txtNumero2.Text);
            double resultado = num1 - num2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNumero1.Text);
            double num2 = Convert.ToDouble(txtNumero2.Text);
            double resultado = num1 * num2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNumero1.Text);
            double num2 = Convert.ToDouble(txtNumero2.Text);

            if (num2 != 0)
            {
                double resultado = num1 / num2;
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Não é possível dividir por zero!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
