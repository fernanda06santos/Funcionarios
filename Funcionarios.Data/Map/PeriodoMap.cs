using Funcionario.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios.Data.Map
{
   public class PeriodoMap:ComplexTypeConfiguration<Periodo>
    {
        public PeriodoMap()
        {
            Property(x => x.DataInicio)
                .HasColumnName("per_dataInicio");

            Property(x => x.DataFim)
                .IsOptional()
                .HasColumnName("per_dataFim");
        }
    }
}
