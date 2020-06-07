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
    public partial class frmLaboratorio10 : Form
    {
        public frmLaboratorio10()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Método de valiação decimal
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        private decimal ValidarDecimal(TextBox txt)
        {
            try
            {
                return Convert.ToDecimal(txt.Text);
            }
            catch
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Preencha corretamente o campo " + txt.Name.ToUpper().Replace("TEXTBOX", ""));
            }
        }
        /// <summary>
        /// Método para limpar os campos
        /// </summary>
        private void LimparTela()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = string.Empty;
                }
                else if (ctl is Label && Convert.ToInt32(ctl.Tag).Equals(1))
                {
                    ctl.Text = string.Empty;
                }
            }
        }


        private void tsbInicio_Click_1(object sender, EventArgs e)
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
            rendimentoLabel.ResetText();

            consumoLabel.ResetText();

            try
            {
                decimal km = ValidarDecimal(kmTextBox);

                decimal litros = ValidarDecimal(litrosTextBox);

                decimal rendimento = km / litros;

                decimal consumo = litros / km;

                rendimentoLabel.Text = rendimento.ToString("N1");

                consumoLabel.Text = consumo.ToString("N3");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}