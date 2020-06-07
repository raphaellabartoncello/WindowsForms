using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impacta.Alunos
{
    public partial class frmLaboratorio03 : Form
    {
        public frmLaboratorio03()
        {
            InitializeComponent();
        }

        private void tsbInicio_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();

            this.Hide();

            principal.Show();
        }

        private void tsbSair_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();

            this.Hide();

            login.Show();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(valor1NumericUpDown.Value);
            int valor2 = Convert.ToInt32(valor2NumericUpDown.Value);
            int valor3 = Convert.ToInt32(valor3NumericUpDown.Value);
            int maior = 0;

            if (valor1 == valor2 && valor2 == valor3)
            {
                resultadoLabel.Text = "Os valores informados são iguais!";

                return;
            }

            else
            {
                if (valor1 > valor2 && valor1 > valor3)
                {
                    maior = valor1;
                }

                else if (valor2 > valor1 && valor2 > valor3)
                {
                    maior = valor2;
                }
                else
                    {
                    maior = valor3;
                }
            }
            resultadoLabel.Text = maior + " é o maior valor!";
        }
    }
}


