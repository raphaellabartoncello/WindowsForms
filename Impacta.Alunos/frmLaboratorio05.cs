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
    public partial class frmLaboratorio05 : Form
    {
        public frmLaboratorio05()
        {
            InitializeComponent();
        }

        private void CalcularTabuada()
        {
            //Limpar a consulta anterior
            tabuadaListBox.Items.Clear();

            int tabuada = Convert.ToInt32(tabuadaTextBox.Text);

            string numero = tabuada.ToString();

            txtTabuada.Text = "A tabuada do " + numero + " é:";

            //Iniciar uma nova consulta
            for (int i = 0; i <= 10; i++)
            {
                tabuadaListBox.Items.Add(tabuada + " x" + i + " = " + (tabuada * i).ToString("#,##0"));
            }
            tabuadaTextBox.Focus();

            tabuadaTextBox.SelectAll();
        }
        private void LimparTela()
        {
            tabuadaTextBox.Clear();
            tabuadaListBox.Items.Clear();
            tabuadaTextBox.Focus();
        }

        private void tabuadaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Permitir apenas NÚMEROS, BACKSPACE e ENTER
            if (
            e.KeyChar >= '0' && e.KeyChar <= '9' ||
            e.KeyChar == '\b' || e.KeyChar == '\r')
            {
                //Se a tecla pressionada for ENTER,
                //chamar o método CalcularTabuada()
                if (e.KeyChar == '\r')
                {
                    CalcularTabuada();
                }
            }
            else
            {
                //Caso não seja uma tecla válida,
                //anular a tecla digitada
                e.KeyChar = '\0';
            }
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
