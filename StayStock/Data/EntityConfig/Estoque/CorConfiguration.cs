using Dominio.Entities.Estoque;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.EntityConfig.Estoque
{
    public class CorConfiguration : EntityTypeConfiguration<Cor>
    {
        public CorConfiguration()
        {
            HasKey(x => x.Identificador);

            Property(c => c.Identificador)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.NomeCor)
                .HasMaxLength(50)
                .IsRequired();

            Property(t => t.CodigoCor)
                .HasMaxLength(20)
                .IsOptional();

            Property(t => t.Descricao)
                .HasMaxLength(100)
                .IsOptional();
        }
    }
}
