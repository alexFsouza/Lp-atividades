using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triangulo_lp
{
    public partial class frmTriangulo : Form
    {
        public frmTriangulo()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double teste = 0;

            string valA = txbValA.Text;
            string valB = txbValB.Text;
            string valC = txbValC.Text;

            if (!double.TryParse(valA, out teste))
            {
                MessageBox.Show("Digite um valor numerico!");

            }
            else if (!double.TryParse(valB, out teste))
            {
                MessageBox.Show("Digite um valor numerico!");

            }
            else if (!double.TryParse(valC, out teste))
            {
                MessageBox.Show("Digite um valor numerico!");

            }
            else
            {
                double valorA = Convert.ToDouble(valA);
                double valorB = Convert.ToDouble(valB);
                double valorC = Convert.ToDouble(valC);

                if (valorA + valorB > valorC && valorB + valorC > valorA && valorA + valorC > valorB)
                {
                    string triangulo = "";

                    if (valorA == valorB && valorC == valorA)
                    {
                       triangulo = "Equilatero";
                       MessageBox.Show("Os valores são lados de um Triangulo " + triangulo);
                    }
                    else if (valorA == valorB || valorB == valorC  || valorA == valorC )
                    {
                        triangulo = "Isósceles";
                        MessageBox.Show("Os valores são lados de um Triangulo " + triangulo);
                    }
                    else
                    {
                        triangulo = "Escaleno";
                        MessageBox.Show("Os valores são lados de um Triangulo " + triangulo);
                    }

                }
                else
                {
                    MessageBox.Show("Os valores não correspondem ao lado de um Triangulo");
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbValA.Clear();
            txbValB.Clear();
            txbValC.Clear();
        }
    }
}
