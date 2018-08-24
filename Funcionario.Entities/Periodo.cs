using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario.Entities
{
    public class Periodo
    {
        public DateTime? DataFim { get; set; }
        public DateTime DataInicio { get; set; } = DateTime.Today;
    }
}
