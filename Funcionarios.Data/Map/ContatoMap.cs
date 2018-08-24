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
   public class ContatoMap : EntityTypeConfiguration<Contato>
    {
        public ContatoMap()
        {
            ToTable("contato");
            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("con_id");

            Property(x => x.Celular)
                .HasColumnName("celular")
                .HasMaxLength(15);

            Property(x => x.Telefone)
                .HasColumnName("telefone")
                .HasMaxLength(15);
                
        }
    }
}
