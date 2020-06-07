using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Impacta.Alunos
{
    class Veiculo : ICadastro
    {

        //Definir a variável caminho
        private string caminho = string.Empty;

        //Definir o método construtor
        public Veiculo(string EnderecoArquivo)
        {
            caminho = EnderecoArquivo;
        }

        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public short Ano { get; set; }
        public string Marca { get; set; }
        public string Observacao { get; set; }
        public Combustiveis Combustivel { get; set; }
        public Cambios Cambio { get; set; }

        public void Gravar()
        {
            //Definir a linha de título do arquivo
            string titulo = @"PLACA;MODELO;COR;ANO;MARCA;COMBUSTÍVEL;CÂMBIO;OBSERVAÇÃO;USUÁRIO;DATA;HORÁRIO";

            //Definir o registro que será gravado
            string registro = string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9}", Placa, Modelo, Cor, Ano.ToString(), Marca, Combustivel.ToString(), Cambio.ToString(), Observacao.Replace(";", ""), Environment.UserName, DateTime.Now.ToString("dd/MM/yyyy;HH:mm:ss"));

            //Verificar se o arquivo já existe
            bool flag = File.Exists(caminho);

            //Definir o objeto StreamWriter
            StreamWriter escritor = new StreamWriter(caminho, true);

            //Se o arquivo não existir, criar o arquivo e escrever o título na primeira linha
            if (!flag)
            {
                escritor.WriteLine(titulo);
            }

            //Escrever o registro no arquivo
            escritor.WriteLine(registro);

            //Fechar a comunicação com o arquivo
            escritor.Close();
        }
    }
}
