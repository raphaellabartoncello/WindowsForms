using System;
using System.Data.SqlClient;

namespace Impacta.Alunos.DLL
{
    class ConexaoDB
    {
        //string conexão para LocalDB (base de dados integrada ao VS)
        private string strConn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=IMPACTA;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public SqlConnection CriarConexao()
        {
            return new SqlConnection(strConn);
        }

        public SqlCommand ObterSqlCommand()
        {
            return new SqlCommand();
        }
    }
}
