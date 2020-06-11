using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impacta.Alunos.MODEL
{
    public class AlunoMOD
    {
        public int AlunoId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public char Sexo { get; set; }

        //TODO Vamos utilizar no mapeamento quando usar EF 6 (Entity Framework)
        //public Curso Curso { get; set; }
    }
}
