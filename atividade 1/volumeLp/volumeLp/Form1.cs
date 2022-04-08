using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volumeLp
{
    public partial class fmrVolume : Form
    {
        public fmrVolume()
        {
            InitializeComponent();
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double teste, volume = 0;
            string raioSt = txbRaio.Text;
            string alturaSt = txbAltura.Text;

            if (!double.TryParse(raioSt, out teste))
            {
                MessageBox.Show("Digite um numero valido");

            }
            else if (!double.TryParse(alturaSt, out teste))
            {
                MessageBox.Show("Digite um numero valido");
            }
            else
            {
                double raio = Convert.ToDouble(raioSt);
                double altura = Convert.ToDouble(alturaSt);
                volume = 3.14 * (raio * raio) * altura ;
                txbVolume.Text = volume.ToString();

            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

