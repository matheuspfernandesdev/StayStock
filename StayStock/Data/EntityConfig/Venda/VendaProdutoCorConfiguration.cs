using Dominio.Entities.Vendas;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.EntityConfig.Venda
{
    public class VendaProdutoCorConfiguration : EntityTypeConfiguration<VendaProdutoCor>
    {
        public VendaProdutoCorConfiguration()
        {
            HasKey(x => x.Identificador);

            Property(c => c.Identificador)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(x => x.ProdutoCor)
                .WithMany(x => x.ListaVendaProdutoCor)
                .HasForeignKey(x => x.IdentificadorProdutoCor);

            HasRequired(x => x.Venda)
                .WithMany(x => x.ListaVendaProdutoCor)
                .HasForeignKey(x => x.IdentificadorVenda);
        }
    }
}
