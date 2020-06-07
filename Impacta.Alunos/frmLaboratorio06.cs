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
    public partial class frmLaboratorio06 : Form
    {
        public frmLaboratorio06()
        {
            InitializeComponent();
        }

        private void validarButton_Click(object sender, EventArgs e)
        {
            //Verificar a consistência dos dados
            if (string.IsNullOrWhiteSpace(cpfTextBox.Text))
            {
                resultadoLabel.Text = "Informe um CPF válido";
                resultadoLabel.ForeColor = Color.Red;
                throw new Exception("Informar o campo CPF é obrigatório");
            }

            //Tratando o CPF informado
            string cpfInformado = cpfTextBox.Text
            .Replace(".", "")
            .Replace("-", "")
            .Replace(" ", "");

            //Verificar o número de posições para validação (11 posições)
            if (cpfInformado.Length != 11)
            {
                MessageBox.Show("CPF é obrigatório, informe o número do CPF com 11 posições");
                cpfTextBox.Focus();
                cpfTextBox.SelectAll();
                return;
                //throw new Exception("Informe a numeração completa do CPF com 11 posições");
            }

            //Separar as primeiras 9 posições (sem os dígitos)
            string cpf = cpfInformado.Substring(0, 9);

            //Definir acumulador
            int soma = 0;

            //CALCULAR PRIMEIRO DÍGITO VERIFICADOR

            //Definir o valor de referência para o cálculo
            int valorRef = 10;

            //Posição vai de 0 a 8 enquanto valorRef vai de 10 a 2
            for (int i = 0; i <= 8; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * valorRef--;
            }
            //Primeiro dígito é o resto do valor acumulado dividido por 11
            int dv1 = (int)(soma % 11);

            //Se dv for menor que 2, então dv vale 0
            //Se dv for maior ou igual a 2, então dv vale 11 menos dv
            if (dv1 < 2)
            {
                dv1 = 0;
            }
            else
            {
                dv1 = 11 - dv1;
            }

            //Verificar se o primeiro dígito verificador informado é válido
            if (!cpfInformado.Substring(9, 1).Equals(dv1.ToString()))
            {
                resultadoLabel.Text = "Informe um CPF válido";
                resultadoLabel.ForeColor = Color.Red;
                return;
                //throw new Exception("Informe um CPF válido");
            }

            //CALCULAR SEGUNDO DÍGITO VERIFICADOR

            //Acrescentando dv1 ao cpf de teste
            cpf = cpf + dv1.ToString();

            //"Zerar" as variáveis
            valorRef = 11;

            soma = 0;

            //Posição vai de 0 a 9 enquanto valorRef vai de 11 a 2
            for (int i = 0; i <= 9; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * valorRef--;
            }

            //Segundo dígito é o resto do valor acumulado dividido por 11
            int dv2 = (int)(soma % 11);

            //Se dv for menor que 2, então dv vale 0
            //Se dv for maior ou igual a 2, então dv vale 11 menos dv
            if (dv2 < 2)
            {
                dv2 = 0;
            }
            else
            {
                dv2 = 11 - dv2;
            }

            //Verificar se o segundo dígito verificador informado é válido
            if (!cpfInformado.Substring(10, 1).Equals(dv2.ToString()))
            {
                resultadoLabel.Text = "Informe um CPF válido";
                resultadoLabel.ForeColor = Color.Red;
                return;
                //throw new Exception("Informe um CPF válido");
            }

            //Mensagem exibida caso CPF seja válido
            resultadoLabel.Text = "CPF válido";
            resultadoLabel.ForeColor = Color.Green;

        }

        private void tsbInicio_Click_1(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();

            this.Hide();

            principal.Show();
        }

        private void tsbSair_Click_1(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();

            this.Hide();

            login.Show();
        }
    }
}
