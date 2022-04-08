using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lp_Imc_alex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double teste =0;
            string peso = txtPeso.Text;
            string altura = txtAltura.Text;


            if (!double.TryParse(peso, out teste))
            {
                MessageBox.Show("Digite um valor numérico!");
            }
            else if (!double.TryParse(altura, out teste))
            {
                MessageBox.Show("Digite um valor numérico");
            }
            else
            {
                double peso1 = Convert.ToDouble(peso);

                double altura1 = Convert.ToDouble(altura);

                double imc = peso1 / (altura1 * altura1);


                if (imc < 18.5)
                {
                    MessageBox.Show(imc + ": Classificação: Magreza, Obsidade Grau: 0");

                }
                else if (imc >= 18.5 & imc < 24.9)
                {
                    MessageBox.Show(imc + ": Classificação: Normal, Obsidade Grau: 0");
                }
                else if (imc >= 25 & imc < 29.9)
                {
                    MessageBox.Show(imc + ": Classificação: Sobre Peso, Obsidade Grau: 1" );
                }
                else if (imc >= 30 & imc < 39.9)
                {
                    MessageBox.Show(imc + ": Classificação: Obesidade, Obsidade Grau: 2");
                }
                else
                {
                    MessageBox.Show(imc + ": Classificação: Obesidade  Grave, Obsidade Grau: 3");
                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             

        }
    }
}
