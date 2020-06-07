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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == string.Empty && string.IsNullOrEmpty(txtSenha.Text))
            {

                AlertaUsuario();
            }
            else
            {
                if (txtUsuario.Text.Trim() == "rapha" && txtSenha.Text == "123")
                {

                    //Instanciar para abertura do próximo formulário
                    frmPrincipal principal = new frmPrincipal();

                    this.Hide();

                    principal.Show();
                }
                else
                {
                    AlertaUsuario();
                }
            }
        }
        private static void AlertaUsuario()
        {
            MessageBox.Show("Usuário ou senha inválidos, tente novamente", "Impacta Alunos");
        }
    }
}
