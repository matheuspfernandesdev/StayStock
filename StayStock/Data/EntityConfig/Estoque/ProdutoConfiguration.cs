using Dominio.Entities.Estoque;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.EntityConfig.Estoque
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(x => x.Identificador);

            Property(c => c.Identificador)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnOrder(1);

            HasRequired(x => x.Fabrica)
                .WithMany(x => x.ListaProdutos)
                .HasForeignKey(x => x.IdentificadorFabrica);

            HasRequired(x => x.TipoProduto)
                .WithMany(x => x.ListaProdutos)
                .HasForeignKey(x => x.IdentificadorTipoProduto);

            Property(t => t.Nome)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnOrder(2);

            Property(t => t.NumeroSerie)
                .HasMaxLength(50)
                .IsOptional();
        }
    }
}
