using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Impacta.Alunos
{
    public partial class frmQueue : Form
    {
        public frmQueue()
        {
            InitializeComponent();
        }

        private void lerButton_Click(object sender, EventArgs e)
        {
            //Conceito FIFO
            Queue fila = new Queue();

            int[] arrayNumeros = new int[4] { 9, 3, 7, 2 };

            //Percorrer o array para inserir os números na fila
            foreach (var item in arrayNumeros)
            {
                //Inserir na fila
                fila.Enqueue(item);

                dadosListBox.Items.Add(string.Format("O número {0} entrou na fila.", item));
            }

            //Interar pela fila
            foreach (var item in fila)
            {
                dadosListBox.Items.Add(new string('=', 20));
                dadosListBox.Items.Add(item);
            }

            //Esvaziar a fila
            while (fila.Count > 0)
            {
                //Cast é uma conversão rápida para o tipo desejado, o casting é necesário para fdazer o unboxing
                int numeroRetiradoDaFila = (int)fila.Dequeue();

                dadosListBox.Items.Add(string.Format("O número {0} saiu da fila.", numeroRetiradoDaFila));
            }
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
    }
}
