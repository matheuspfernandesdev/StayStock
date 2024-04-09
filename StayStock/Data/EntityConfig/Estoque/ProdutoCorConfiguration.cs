using Dominio.Entities.Estoque;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.EntityConfig.Estoque
{
    public class ProdutoCorConfiguration : EntityTypeConfiguration<ProdutoCor>
    {
        public ProdutoCorConfiguration()
        {
            HasKey(x => x.Identificador);

            Property(c => c.Identificador)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasOptional(x => x.Cor)
                .WithMany(x => x.ListaProdutoCor)
                .HasForeignKey(x => x.IdentificadorCor);

            HasRequired(x => x.Produto)
                .WithMany(x => x.ListaProdutoCor)
                .HasForeignKey(x => x.IdentificadorProduto);

            Property(t => t.Descricao)
                .HasMaxLength(100)
                .IsOptional();
        }
    }
}
