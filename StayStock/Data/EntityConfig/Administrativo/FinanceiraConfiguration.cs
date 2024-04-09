using Dominio.Entities.Administrativo;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.EntityConfig.Administrativo
{
    public class FinanceiraConfiguration : EntityTypeConfiguration<Financeira>
    {
        public FinanceiraConfiguration()
        {
            HasKey(x => x.Identificador);

            Property(c => c.Identificador)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.Nome)
                .HasMaxLength(100)
                .IsRequired();

            Property(t => t.Usuario)
                .HasMaxLength(30)
                .IsRequired();

            Property(t => t.Login)
                .HasMaxLength(30)
                .IsRequired();

            Property(t => t.Senha)
                .HasMaxLength(100)
                .IsRequired();

            Property(t => t.Descricao)
                .HasMaxLength(2000)
                .IsOptional();
        }
    }
}
