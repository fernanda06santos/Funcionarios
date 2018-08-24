using Funcionario.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios.Data.Map
{
   public class PessoaFisicaMap:EntityTypeConfiguration<PessoaFisica>
    {
        public PessoaFisicaMap()
        {
            ToTable("pessoafisica");
           
            Property(x => x.Cpf)
                .HasColumnName("cpf")
                .HasMaxLength(11);

            Property(x => x.DataNascimento)
                .HasColumnName("dataNascimento")
                .HasColumnType("datetime2");

            Property(x => x.Idade)
                .HasColumnName("idade");
        }
    }
}
