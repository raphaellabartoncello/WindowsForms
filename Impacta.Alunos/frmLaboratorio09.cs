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
    public partial class frmLaboratorio09 : Form
    {
        public frmLaboratorio09()
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

        private void pastaButton_Click(object sender, EventArgs e)
        {
            //Limpar o endereço anterior
            enderecoLabel.Text = string.Empty;
            try
            {
                //Verificar se alguma pasta foi escolhida
                if (folderBrowserDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    //Atribuir o endereço da pasta a label
                    enderecoLabel.Text = folderBrowserDialog1.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trocarButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Verificar se há um endereço para troca
                if (enderecoLabel.Text.Trim() == string.Empty)
                {
                    throw new Exception("Selecione a pasta para efetivar a troca de nomes");
                }
                //Verificar se há um valor procurado para a troca
                if (deTextBox.Text.Trim() == string.Empty)
                {
                    throw new Exception("Informe o valor procurado para a troca");
                }
                //Definir um array com os arquivos da pasta
                System.IO.FileInfo[] arquivos = new System.IO.DirectoryInfo(enderecoLabel.Text).GetFiles();

                //Percorrer o array para efetivar a troca
                foreach (var arquivo in arquivos)
                {
                    //Definir o novo nome e endereço do arquivo
                    string novoNome = enderecoLabel.Text + "\\" + arquivo.Name.Replace(deTextBox.Text, paraTextBox.Text);

                    //Verificar se o arquivo já existe
                    if (!System.IO.File.Exists(novoNome))
                    {
                        //Caso não exista, criá-lo
                        arquivo.CopyTo(novoNome);

                        //Excluir o arquivo antigo
                        arquivo.Delete();
                    }
                }
                MessageBox.Show("Troca efetuada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
