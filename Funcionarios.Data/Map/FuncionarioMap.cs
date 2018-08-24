using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios.Data.Map
{
    public class FuncionarioMap : EntityTypeConfiguration<Funcionario.Entities.Funcionario>
    {
        public FuncionarioMap()
        {
            ToTable("funcionario");


            Property(x => x.DataContratacao)
                .HasColumnName("dataContratacao");

            Property(x => x.Salario)
                .HasColumnName("salario");
        }
    }
}
