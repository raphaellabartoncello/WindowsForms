using System;
using System.Collections;
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
    public partial class frmExtraStack : Form
    {
        public frmExtraStack()
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

        private void lerButton_Click(object sender, EventArgs e)
        {
            Stack<int> pilha = new Stack<int>();

            // Preenchendo a pilha
            foreach (var item in new int[4] { 9, 3, 7, 2 })
            {
                // Para inserir itens na pilha usar o método PUSH
                pilha.Push(item);

                dadosListBox.Items.Add(string.Format("O número {0} foi colocado na pilha.", item));
            }

            // Interar pela pilha 
            foreach (var item in pilha)
            {
                dadosListBox.Items.Add(new string('=', 20));
                dadosListBox.Items.Add(item);
            }

            // Para retirar itens da pilha usar o método POP
            while (pilha.Count > 0)
            {
                int numeroRetiradoDaPilha = (int)pilha.Pop();

                dadosListBox.Items.Add(string.Format("O número {0} foi Retirado da pilha.", numeroRetiradoDaPilha));
            }
        }
    }
}


