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
    public partial class frmLaboratorio04 : Form
    {
        public frmLaboratorio04()
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

        private void Calcular()
        {
            decimal valor = 0;
            decimal perc = 0;

            valor = Convert.ToDecimal(valorTextBox.Text);

            string uf = ufComboBox.Text.ToUpper();

            switch (uf)
            {
                case "AM":
                    perc = 0.6m; break;
                case "MG":
                    perc = 0.35m; break;
                case "RJ":
                    perc = 0.3m; break;
                case "SP":
                    perc = 0.2m; break;
                default:
                    perc = 0.75m; break;
            }
            valorTextBox.Text = valor.ToString("N2");

            decimal custo = 0;
            string c;

            custo = valor * (1 + perc);
            c = custo.ToString("C2");

            freteLabel.Text = perc.ToString("P1");

            totalLabel.Text = ("O valor total do frete para " + uf + " é de " + c);
        }

        private void LimparTela()
        {
            clienteTextBox.Clear();
            valorTextBox.Clear();
            ufComboBox.SelectedIndex = -1;
            freteLabel.Text = string.Empty;
            totalLabel.Text = string.Empty;
            clienteTextBox.Focus();
        }

        private void frmLaboratorio04_Load(object sender, EventArgs e)
        {
            ufComboBox.SelectedIndex = -1;
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            freteLabel.Text = string.Empty;
            totalLabel.Text = string.Empty;

            if (clienteTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("O preenchimento do campo Nome é obrigatório.", "Impacta Alunos - Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                clienteTextBox.Focus();
                return;
            }
            else if (valorTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("O preenchimento do campo Valor é obrigatório.", "Impacta Alunos - Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valorTextBox.Focus();
                return;
            }

            else if (ufComboBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("O preenchimento do campo UF é obrigatório.", "Impacta Alunos - Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ufComboBox.Focus();
                return;
            }

            Calcular();
        }

        private void frmLaboratorio04_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                LimparTela();
            }
        }

        private void ufComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (ufComboBox.SelectedIndex != -1)
                {
                    calcularButton.PerformClick();
                }
            }
        }
    }
}