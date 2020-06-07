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
    public partial class frmLaboratorio02 : Form
    {
        public frmLaboratorio02()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            decimal valorCompra = 0;
            decimal valorPago = 0;
            decimal resto = 0;

            valorCompra = Convert.ToDecimal(valorCompraTextBox.Text);
            valorPago = Convert.ToDecimal(valorPagoTextBox.Text);

            resto = valorPago - valorCompra;

            int moedas1 = (int)(resto / 1);
            resto = resto % 1;
            moedas1Label.Text = moedas1.ToString();

            int moedas050 = (int)(resto / 0.50m);
            resto = resto % 0.50m;
            moedas050Label.Text = moedas050.ToString();

            int moedas025 = (int)(resto / 0.25m);
            resto = resto % 0.25m;
            moedas025Label.Text = moedas025.ToString();

            int moedas010 = (int)(resto / 0.10m);
            resto = resto % 0.10m;
            moedas010Label.Text = moedas010.ToString();

            int moedas005 = (int)(resto / 0.05m);
            resto = resto % 0.05m;
            moedas005Label.Text = moedas005.ToString();

            int moedas001 = (int)(resto / 0.01m);
            resto = resto % 0.01m;
            moedas001Label.Text = moedas001.ToString();

            trocoLabel.Text = (moedas1 + moedas050 * 0.5 + moedas025 * 0.25 + moedas010 * 0.1 + moedas005 * 0.05 + moedas001 * 0.01).ToString("C2");
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
    }
}

