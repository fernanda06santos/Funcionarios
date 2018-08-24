using Funcionario.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios.Data.Map
{
    public class PessoaMap:EntityTypeConfiguration<Pessoa>
    {
        public PessoaMap()
        {
            ToTable("pessoa");
            HasKey(x=> x.Id)
                .Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("pes_id");

            Property(x => x.Enderecos)
                .HasColumnName("enderecos")
                .HasMaxLength(150);

            Property(x => x.Nome)
                .HasColumnName("nome")
                .HasMaxLength(200);

            HasMany(x => x.Contatos).WithMany().Map(x => x.ToTable("pessoa_contatos"));
        }
    }
}
