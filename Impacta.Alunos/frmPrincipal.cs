using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impacta.Alunos
{
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();

           //     /*Apresentar o nome do usuário logado na barra de status
           //      * Para isso, antes de chamar o frmPrincipal abro o sumário:
           //      *  /// <summary>
           //*  /// Método construtor
           // *  /// </summary>
           // *  /// <parm name="nomeUsuario">Nome do usuário logado a ser apresentado na barra de status</parm>
           // *  /// e chamo passando o parametro:
           //*   ///         public frmPrincipal(string nomeUsuario)
           //* {
           //  *   InitializeComponent();
           //  *   tssUsuario.Text = nomeUsuario.ToUpper();
           //  *   }
           //     */

            //Apresentar o nome do usuário logado na barra de status
            tssData.Text = DateTime.Now.ToString("D",
                  CultureInfo.CreateSpecificCulture("pt-BR"));
            tssHora.Text = DateTime.Now.ToString("t",
                  CultureInfo.CreateSpecificCulture("pt-BR"));

            lblDataHora.Text = DateTime.Now.ToString();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Atualização automática do relógio (tempo real)
            lblDataHora.Text = DateTime.Now.ToString();
        }

        private void tsbSair_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();

            this.Hide();

            login.Show();
        }

        private void laboratório01ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmLaboratorio01 lab01 = new frmLaboratorio01();

            this.Hide();

            lab01.Show();
        }

        private void laboratório02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLaboratorio02 lab02 = new frmLaboratorio02();

            this.Hide();

            lab02.Show();
        }

        private void laboratório03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLaboratorio03 lab03 = new frmLaboratorio03();

            this.Hide();

            lab03.Show();
        }

        private void laboratório04ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLaboratorio04 lab04 = new frmLaboratorio04();

            this.Hide();

            lab04.Show();
        }

        private void laboratório05ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLaboratorio05 lab05 = new frmLaboratorio05();

            this.Hide();

            lab05.Show();
        }

        private void laboratório06ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLaboratorio06 lab06 = new frmLaboratorio06();

            this.Hide();

            lab06.Show();
        }

        private void laboratório07ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLaboratorio07 lab07 = new frmLaboratorio07();

            this.Hide();

            lab07.Show();
        }

        private void laboratório08ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLaboratorio08 lab08 = new frmLaboratorio08();

            this.Hide();

            lab08.Show();
        }

        private void laboratório09ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLaboratorio09 lab09 = new frmLaboratorio09();

            this.Hide();

            lab09.Show();
        }

        private void laboratório10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLaboratorio10 lab10 = new frmLaboratorio10();

            this.Hide();

            lab10.Show();
        }
        private void escalaçãoDeJogadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExtraJogadores jogadores = new frmExtraJogadores();

            this.Hide();

            jogadores.Show();
        }

        private void coleçãoStackPilhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExtraStack stack = new frmExtraStack();

            this.Hide();

            stack.Show();
        }

        private void coleçãoQueueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQueue queue = new frmQueue();

            this.Hide();

            queue.Show();
        }

        private void cadastroDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroAluno aluno = new frmCadastroAluno();

            this.Hide();

            aluno.Show();
        }
    }
}
