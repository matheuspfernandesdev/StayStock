using Dominio.Entities.Estoque;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.EntityConfig.Estoque
{
    public class TipoProdutoConfiguration : EntityTypeConfiguration<TipoProduto>
    {
        public TipoProdutoConfiguration()
        {
            HasKey(x => x.Identificador);

            Property(c => c.Identificador)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnOrder(1);

            Property(t => t.Nome)
                .HasMaxLength(100)
                .HasColumnOrder(2)
                .IsRequired();

            Property(t => t.Descricao)
                .HasMaxLength(1000)
                .IsOptional();
        }
    }
}
