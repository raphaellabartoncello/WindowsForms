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
    public partial class frmLaboratorio08 : Form
    {
        public frmLaboratorio08()
        {
            InitializeComponent();
        }

        private void lerButton_Click(object sender, EventArgs e)
        {
            dadosListBox.Items.Clear();

            //Definindo a variável endereço
            string endereco = @"C:\Users\Raphaella\Documents\Projects\WindowsForms\arquivoClientes.txt";
            try
            {
                if (!System.IO.File.Exists(endereco))
                {
                    throw new Exception("arquivoClientes.txt não foi localizado!");
                }

                //Definir array do tipo string com 4 posições
                string[] dados = new string[4];

                //Definir o objeto StreamReader
                System.IO.StreamReader leitor = new System.IO.StreamReader(endereco, System.Text.Encoding.UTF8);

                //Definir o cabeçalho na ListBox ("NOME CABEÇALHO.Retorna uma nova cadeia de caracteres que alinha os caracteres à esquerda nessa cadeia de caracteres, preenchendo-os com espaços à direita, para um tamanho total especificadO)
                dadosListBox.Items.Add("CÓDIGO".PadRight(7) + "CLIENTE".PadRight(40) + "CIDADE".PadRight(20) + "PAÍS");
                dadosListBox.Items.Add(new string('-', 80));

                //Ler os dados enquanto o arquivo não acabar
                while (!leitor.EndOfStream)
                {
                    //A instrução split desmonta a linha de registro nos pontos e vírgulas e entrega nas respectivas posições do array
                    dados = leitor.ReadLine().Split(';');

                    //Exibir os dados na lista com largura fixa, preenchendo com espaços em branco à direita
                    dadosListBox.Items.Add(dados[0].PadRight(7) + dados[1].PadRight(40) + dados[2].PadRight(20) + dados[3]);
                }

                //Fechar o acesso ao arquivo de texto
                leitor.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Alerta de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
