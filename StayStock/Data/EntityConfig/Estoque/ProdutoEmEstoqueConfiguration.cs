using Dominio.Entities.Estoque;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.EntityConfig.Estoque
{
    public class ProdutoEmEstoqueConfiguration : EntityTypeConfiguration<ProdutoEmEstoque>
    {
        public ProdutoEmEstoqueConfiguration()
        {
            HasKey(x => x.Identificador);

            Property(c => c.Identificador)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(x => x.ProdutoCor)
                .WithMany(x => x.ListaProdutosEmEstoque)
                .HasForeignKey(x => x.IdentificadorProdutoCor);
        }
    }
}
