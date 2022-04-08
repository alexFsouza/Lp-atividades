using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pVolume
{
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {


            double teste = 0;

            string num1 = txtNum1.Text;
            string num2 = txtNum2.Text;

            if (!double.TryParse(num1, out teste))
            {

                MessageBox.Show("Digite um numero valido");

            }
            else if (!double.TryParse(num2, out teste))
            {
                MessageBox.Show("Digite um numero valido");
            }
            else {
                double numero1 = Convert.ToDouble(num1);
                double numero2 = Convert.ToDouble(num2);
                double resultado = numero1 + numero2;
                txtResultado.Text = resultado.ToString();

            }




        }

        public void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double teste = 0;

            string num1 = txtNum1.Text;
            string num2 = txtNum2.Text;

            if (!double.TryParse(num1, out teste))
            {

                MessageBox.Show("Digite um numero valido");

            }
            else if (!double.TryParse(num2, out teste))
            {
                MessageBox.Show("Digite um numero valido");
            }
            else
            {
                double numero1 = Convert.ToDouble(num1);
                double numero2 = Convert.ToDouble(num2);
                double resultado = numero1 - numero2;
                txtResultado.Text = resultado.ToString();

            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double teste = 0;

            string num1 = txtNum1.Text;
            string num2 = txtNum2.Text;

            if (!double.TryParse(num1, out teste))
            {

                MessageBox.Show("Digite um numero valido");

            }
            else if (!double.TryParse(num2, out teste))
            {
                MessageBox.Show("Digite um numero valido");
            }
            else
            {
                double numero1 = Convert.ToDouble(num1);
                double numero2 = Convert.ToDouble(num2);
                double resultado = numero1 * numero2;
                txtResultado.Text = resultado.ToString();

            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double teste = 0;

            string num1 = txtNum1.Text;
            string num2 = txtNum2.Text;

            if (!double.TryParse(num1, out teste))
            {

                MessageBox.Show("Digite um numero valido");

            }
            else if (!double.TryParse(num2, out teste))
            {
                MessageBox.Show("Digite um numero valido");
            }
            else
            {
                double numero1 = Convert.ToDouble(num1);
                double numero2 = Convert.ToDouble(num2);
                double resultado = numero1 / numero2;
                txtResultado.Text = resultado.ToString();

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja sair da aplicação?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.No) return;
            Application.Exit();
            
        }
    }
}
