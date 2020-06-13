using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impacta.Alunos.BusinessBLL
{
    public static class MetodoExtensao
    {
        /// <summary>
        /// Método para validar se o campo texto está vazio
        /// </summary>
        /// <param name="texto"></param>
        /// <returns>Texto já validado</returns>
        public static bool ValidarNomeVazio(this string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return false;
            }
            return true;
        }

        public static bool ValidarEmail(this String emailString)
        {
            bool isEmail = Regex.IsMatch(emailString, @"\A(?:[a-z0-9!#$%&'+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'+/=?^_`{|}~-]+)@(?:[a-z0-9](?:[a-z0-9-][a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

            return isEmail;
        }

        public static string RemoverMascara(this String textoComMascara)
        {
            var txt = textoComMascara
             .Replace("(", "")
             .Replace(")", "")
             .Replace("-", "")
             .Replace(".", "")
             .Replace(",", "")
             .Replace(" ", "")
             .Trim();

            if (String.IsNullOrWhiteSpace(txt))
            {
                throw new Exception("Impossível remover a máscara do campo informado");
            }

            return txt;
        }
        public static bool ValidarCPF(this String texto)
        {

            //Consistir os dados
            if (string.IsNullOrWhiteSpace(texto))
            {
                throw new Exception("CPF é obrigatório");
            }

            //Definir as variáveis
            //Tratando o CPF informado
            string cpfInformado = texto
                                    .Replace(".", "")
                                    .Replace("-", "")
                                    .Replace(" ", "");

            //Verificar o número de posições para validação (11 posições)
            if (cpfInformado.Length != 11)
            {
                throw new Exception("Informe um CPF com 11 posições");
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
                throw new Exception("Informe um CPF válido");
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
                throw new Exception("Informe um CPF válido");
            }

            //Mensagem exibida caso CPF seja válido
            return true;
        }

        public static void LimparTela(this Form formulario)
        {
            foreach (Control ctl in formulario.Controls)
            {
                //A IS realiza o UNBOXING de forma amigável (UNBOXING - Compara se o objeto que está dentro de alguma coleção é do tipo que quero comparar)
                if (ctl is TextBox)
                {
                    ctl.Text = string.Empty;

                }

                else if (ctl is ComboBox)
                {

                    (ctl as ComboBox).SelectedIndex = -1;

                }

                else if (ctl is MaskedTextBox)
                {
                    ctl.Text = string.Empty;
                }

                else if (ctl is RadioButton)
                {
                    ctl.Enabled = false;
                }
            }
        }
    }
}

