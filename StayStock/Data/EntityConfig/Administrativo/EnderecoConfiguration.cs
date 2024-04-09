using Dominio.Entities.Administrativo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EntityConfig
{
    public class EnderecoConfiguration : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfiguration()
        {
            HasKey(c => c.Identificador);

            Property(c => c.Identificador)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.Bairro)
                .HasMaxLength(50)
                .IsRequired();

            Property(t => t.Rua)
                .HasMaxLength(50)
                .IsRequired();

            Property(t => t.Numero)
                .HasMaxLength(10)
                .IsRequired();

            Property(t => t.Municipio)
                .HasMaxLength(50)
                .IsRequired();

            Property(t => t.CEP)
                .IsOptional();
        }
    }
}
