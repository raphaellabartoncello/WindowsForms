using Microsoft.VisualBasic;
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
    public partial class frmExtraJogadores : Form
    {
        public frmExtraJogadores()
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Informe o número de jogadores!", "Impacta Alunos");

                    return;
                }

                List<string> jogadores = new List<string>();

                //Desativar a funcionalidade do botão adicionar
                btnAdd.Enabled = false;

                //Adicionar jogadores conforme a quantidade informada
                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    //Capturar o nome dos jogadores
                    jogadores.Add(Interaction.InputBox("Digite o nome do Jogador", "Captura de nomes"));
                }

                foreach (var nome in jogadores)
                {
                    lstListaDeJogadores.Items.Add(nome);
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro, verifique: " + erro.Message, "Impacta Alunos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblEscalar_Click(object sender, EventArgs e)
        {
            try
            {
                //Verifique se há algum item selecionado na caixa Jogadores
                if (lstListaDeJogadores.SelectedIndex < 0)
                {
                    throw new Exception("Por favor selecione um jogador");
                }
                //Adicionar o nome selecionado na lista Escalação
                lstEscalacao.Items.Add(lstListaDeJogadores.SelectedItem);

                //Remover o nome selecionado da lista Jogadores
                lstListaDeJogadores.Items.RemoveAt(lstListaDeJogadores.SelectedIndex);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Verifique o erro: " + ex.Message, "Impacta Alunos");
            }
        }

        private void lblRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstEscalacao.SelectedIndex < 0)
                {
                    throw new Exception("Por favor selecione um jogador");
                }

                lstListaDeJogadores.Items.Add(lstEscalacao.SelectedItem);

                lstEscalacao.Items.RemoveAt(lstEscalacao.SelectedIndex);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Verifique o erro: " + ex.Message, "Impacta Alunos");
            }
        }
    }
}
