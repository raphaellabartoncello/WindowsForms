using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Impacta.Alunos.DLL;
using Impacta.Alunos.MODEL;

namespace Impacta.Alunos.BusinessBLL
{
    public class AlunoBLL
    {
        public bool CadastrarAluno(AlunoMOD alunoMOD)
        {
            //Variável que conecta a nossa Data Access Layer
            AlunoDLL alunoDLL = null;

            //Variável para capturar retorno
            var retorno = false;

            //Validar qualquer regra de negócio nesta camada (Ex. CPF, campos obrigatórios)
            try
            {

                if (ValidarDadosAlunos(alunoMOD))
                {
                    //Se os dados forem validados com sucesso - Criar estância da camada BLL
                    alunoDLL = new AlunoDLL();

                    //Chamar método para inserção no banco de dados
                    retorno = alunoDLL.CadastrarAluno(alunoMOD);

                }
            }

            catch (Exception ex)
            {

                throw;
            }
            return retorno;
        }

        public bool ValidarDadosAlunos(AlunoMOD aluno)
        {
            return aluno.Nome.ValidarVazio();
        }
    }
}
