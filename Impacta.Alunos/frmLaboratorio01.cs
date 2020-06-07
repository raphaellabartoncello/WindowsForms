using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impacta.Alunos
{
    public partial class frmLaboratorio01 : Form
    {
        public frmLaboratorio01()
        {
            InitializeComponent();

        }

        private void tsbSair_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();

            this.Hide();

            login.Show();
        }

        private void tsbInicio_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();

            this.Hide();

            principal.Show();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            int numero = 0;
            int quadrado = 0;

            numero = Convert.ToInt32(valorTextBox.Text);

            quadrado = numero * numero;

            resultadoLabel.Text = "Quadrado de " + numero.ToString() + " é: " + quadrado.ToString("N0");

            valorTextBox.Focus();

            valorTextBox.SelectAll();

        }
    }
}
