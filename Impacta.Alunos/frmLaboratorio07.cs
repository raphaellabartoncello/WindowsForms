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
    public partial class frmLaboratorio07 : Form
    {
        public frmLaboratorio07()
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

        private void tsbInicio_Click_1(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();

            this.Hide();

            principal.Show();
        }

        private void tsbSair_Click_1(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();

            this.Hide();

            login.Show();
        }

        private void frmLaboratorio07_Load(object sender, EventArgs e)
        {
            //Carregar combustivelComboBox
            combustivelComboBox.DataSource = Enum.GetNames(typeof(Combustiveis));

            //Desmarcar a combo
            combustivelComboBox.SelectedIndex = -1;

            //Carregar cambioComboBox
            cambioComboBox.DataSource = Enum.GetNames(typeof(Cambios));

            //Desmarcar a combo
            cambioComboBox.SelectedIndex = -1;

            //Carregar marcaComboBox

            //Limpar dados anteriores
            marcaComboBox.Items.Clear();

            //Importar o arquivo .txt com as informações de marcas
            System.IO.StreamReader leitor = new System.IO.StreamReader(@"C:\Users\Raphaella\Documents\Projects\WindowsForms\Marcas.txt");
            while (!leitor.EndOfStream)
            {
                marcaComboBox.Items.Add(leitor.ReadLine());
            }
            leitor.Close();
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo carro = new Veiculo(@"C:\Users\Raphaella\Documents\Projects\WindowsForms\Cadastro de Veículos.txt");

                //Atribuir valor às propriedades do veículo com as devidas validações
                carro.Placa = placaTextBox.ValidarVazio().ValidarPlaca();
                carro.Modelo = modeloTextBox.ValidarVazio();
                carro.Cor = corTextBox.ValidarVazio();
                carro.Ano = anoTextBox.ValidarInt16().ValidarAno();
                carro.Marca = marcaComboBox.ValidarCombo();
                carro.Observacao = observacaoTextBox.Text;

                //Fazendo CAST
                carro.Combustivel = (Combustiveis)combustivelComboBox.ValidarComboEnum();

                carro.Cambio = (Cambios)cambioComboBox.ValidarComboEnum();

                //Chamar o método gravar do veículo
                carro.Gravar();

                //Avisar o usuário
                MessageBox.Show("Veículo gravado com sucesso!", "Impacta Alunos - Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Redefinir a tela
                this.LimparTela();
                placaTextBox.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void observacaoTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                toquesLabel.Text = "Restante: " + (300 - observacaoTextBox.TextLength).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLaboratorio07_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Passar a propriedade KeyPreview do formulário para TRUE
            if (e.KeyChar == 27)
            {
                this.LimparTela();
            }
        }
    }
}
