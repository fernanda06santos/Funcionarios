using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario.Entities
{
    public class Funcionario:PessoaFisica 
    {
        public DateTime  DataContratacao { get; set; }
        public decimal Salario { get; set; }
    }
}
