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

                aluno.Nome = txtNomeAluno.Text;
                aluno.Cpf = txtCpf.Text;
                aluno.Email = txtEmail.Text;
                aluno.Telefone = txtTelefone.Text;

                alunoBus.CadastrarAluno(aluno);

            }
            catch (Exception ex)
            {

                if (ex.Message.Contains("Nome"))
                {
                    errorProvider1.SetError(txtNomeAluno, ex.Message);
                }
                else if (ex.Message.Contains("Email"))
                {
                    errorProvider1.SetError(txtEmail, ex.Message);
                }
                else if (ex.Message.Contains("Cpf"))
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
    }
}
