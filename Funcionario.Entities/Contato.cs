using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario.Entities
{
   public class Contato
    {
        public string Celular { get; set; }
        public int Id { get; set; }
        public string Telefone { get; set; }
        public Periodo Vigencia { get; set; }
    }
}
