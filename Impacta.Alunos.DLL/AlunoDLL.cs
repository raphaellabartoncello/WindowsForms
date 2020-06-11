using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Impacta.Alunos.MODEL;

namespace Impacta.Alunos.DLL
{
    class AlunoDLL
    {
        //Importar e fazer referência a classe que cria a conexão com o banco de dados
        ConexaoDB minhaConexaoDB = null;

        //Criar um construtor, nele criar uma nova instância do banco de dados

        public AlunoDLL()
        {
            if (minhaConexaoDB == null)
            {
                minhaConexaoDB = new ConexaoDB();
            }
        }

        public bool CadastrarAluno(AlunoMOD alunoMOD)
        {

            bool retornoDB = false;
            try
            {
                //Para criar um comando SQL e executar instruções SQL no Banco de Dados utilizar SqlCommand
                var comandoSql = minhaConexaoDB.ObterSqlCommand();

                //Preencher o comando SQL a ser executado no banco de dados
                comandoSql.Connection = minhaConexaoDB.CriarConexao();

                //QUERY
                comandoSql.CommandText = @"INSERT INTO ALUNOS(NOME, EMAIL, TELEFONE, CPF, SEXO) VALUES " + "@Nome, @Email, @Telefone, @Cpf, @Sexo";

                //Trocar parametros pelos valores dos objetos
                SqlParameter param = new SqlParameter();

                comandoSql.Parameters.AddWithValue("@Nome", alunoMOD.Nome);
                comandoSql.Parameters.AddWithValue("@Email", alunoMOD.Email);
                comandoSql.Parameters.AddWithValue("@Telefone", alunoMOD.Telefone);
                comandoSql.Parameters.AddWithValue("@Cpf", alunoMOD.Cpf);
                comandoSql.Parameters.AddWithValue("@Sexo", alunoMOD.Sexo);

                //Abrir conexão com o banco de dados
                comandoSql.Connection.Open();

                //Executar o INSERT - Com if ternário obter o valor bool para retornar o método
                retornoDB = comandoSql.ExecuteNonQuery() >= 1 ? true : false;


            }
            catch (Exception ex)
            {

                throw ex;
            }

            return retornoDB;
        }
    }
}
