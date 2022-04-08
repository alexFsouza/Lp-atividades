using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalhoSalario
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void d_Click(object sender, EventArgs e)
        {
            string nome = mtbNome.Text;
            string salarioSt = mtbSalBruto.Text;
            string numFilhos = mtbNumFilhos.Text;
            
            double irpf, aliquota, salFamilia, salBruto, filhos = 0;


            if (!double.TryParse(salarioSt, out salBruto) && (!double.TryParse(numFilhos, out filhos)))
            {
                MessageBox.Show("Digite um valor valido!");      
            }
            else
            {

                try
                {
                    filhos = Convert.ToDouble(numFilhos);
                    salBruto = Convert.ToDouble(salarioSt);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

         
            //calculo inss
            if (salBruto <= 800.47 )
            {
                mtbAliqInss.Text = "7.65%";

                aliquota = salBruto * 0.0765;
                

                string ali = Convert.ToString(aliquota);
                mtbDescInss.Text = ali;
            }
            else if (salBruto < 1050)
            {
                mtbAliqInss.Text = "8.65%";

                aliquota = salBruto * 0.0865;
                

                string ali = Convert.ToString(aliquota);
                mtbDescInss.Text = ali;
            }
            else if (salBruto < 1400.77)
            {
                mtbAliqInss.Text = "9.00";
                aliquota = salBruto * 0.0900;
                string ali = Convert.ToString(aliquota);
                mtbDescInss.Text = ali;
            }
            else if (salBruto < 2801.56)
            {
                mtbAliqInss.Text = "11.00%";
                aliquota =  salBruto * 0.011;             
                string ali = Convert.ToString(aliquota);
                mtbDescInss.Text = ali;
            }
            else
            {
                mtbAliqInss.Text = "0";
                mtbDescInss.Text = "308.17";
                aliquota = 0;
            }//fim calculo inss
           

            //calculo salario familia
            if (salBruto <= 345.52)
            {
                salFamilia = 22.33 * filhos;
                string valFami = Convert.ToString(salFamilia);
                mtbSalFamilia.Text = valFami;

            }else if( salBruto < 654.61)
            {
                salFamilia = 15.74 * filhos;
               double familia = salFamilia;
               
                string valFami = Convert.ToString(salFamilia);
                mtbSalFamilia.Text = valFami;

            }else
            {
                mtbSalFamilia.Text = "0,00";
                salFamilia = 0;
            }//fim calculo salario familia


            //calculo irpf
            if(salBruto <=1257.12)
            {
                mtbDescIrpf.Text = "0,00";
                mtbAliqIrpf.Text = "0%";
                irpf = 0;
                

            }
            else if (salBruto <= 2512.08)
            {
                irpf = salBruto * 0.15;          
                mtbAliqIrpf.Text = "15%";

                string valIrpf = Convert.ToString(irpf);
                mtbDescIrpf.Text = valIrpf;
            }
            else
            {
                irpf = salBruto * 0.27;
                mtbAliqIrpf.Text = "27%";

                string valIrpf = Convert.ToString(irpf);
                mtbDescIrpf.Text = valIrpf;

            }//fim calculo irpf


            //salario liquido
            double total = salBruto - aliquota - irpf + salFamilia;
            mtbSalLiquido.Text = Convert.ToString(total);


            //checkbox
            string genero, casado;
            
            if (rdbF.Checked)
            {
                genero = "Sra.";
            }
            else
            {
                genero = "Sr.";
            }

            if (ckbCasado.Checked)
            {
                casado = "Casado(a)";
            }
            else
            {
                casado = "Solteiro(a)";
            }


            //saida

            txbResult.Text = ("Os descontos do salário do "+ genero + nome + " que é " + casado + "e que tem " + numFilhos + "(s) são:");
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
