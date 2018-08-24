using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario.Entities
{
   public class PessoaFisica:Pessoa 
    {
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get; set; }
    }
}
