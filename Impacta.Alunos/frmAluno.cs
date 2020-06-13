using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Impacta.Alunos.BusinessBLL;
using Impacta.Alunos.MODEL;
using MetroFramework.Forms;

namespace Impacta.Alunos
{
    public partial class frmAluno : MetroForm
    {
        public frmAluno()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Definir objeto do tipo MODELO
            //Iniciar como null e instanciar apenas se for utilizar
            AlunoMOD aluno = null;

            try
            {
                //Criar um objeto BLL para armazenar os dados do form
                AlunoBLL alunoBus = new AlunoBLL();


                //Instanciar aluno MODEL        
                aluno = new AlunoMOD();

                aluno.Nome = txtNome.Text;
                aluno.Cpf = txtCpf.Text.RemoverMascara();
                aluno.Email = txtEmail.Text;
                aluno.Telefone = txtTelefone.Text.RemoverMascara();
                aluno.Sexo = 'M';

                if (alunoBus.CadastrarAluno(aluno))
                {
                    this.LimparTela();

                    MessageBox.Show("Impacta Alunos", "Aluno cadastrado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {
                    MessageBox.Show("Impacta Alunos", "Problema ao cadastrar o aluno.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {

                if (ex.Message.Contains("Nome"))
                {
                    errorProvider1.SetError(txtNome, ex.Message);
                }
                else if (ex.Message.Contains("Email"))
                {
                    errorProvider1.SetError(txtEmail, ex.Message);
                }
                else if (ex.Message.Contains("CPF"))
                {
                    errorProvider1.SetError(txtCpf, ex.Message);
                }
                else if (ex.Message.Contains("Tel"))
                {
                    errorProvider1.SetError(txtTelefone, ex.Message);
                }

                else
                {
                    MessageBox.Show("Ocorreu uma falha, por favor informar o administrador do sistema: \n" + ex.StackTrace);
                }
            }

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            //Remover o blink do ERROR PROVIDER
            errorProvider1.SetError(txtNome, string.Empty);
        }
    }
}
