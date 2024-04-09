using Dominio.Entities.Vendas;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.EntityConfig.Venda
{
    public class PromissoriaConfiguration : EntityTypeConfiguration<Promissoria>
    {
        public PromissoriaConfiguration()
        {
            HasKey(x => x.Identificador);

            Property(c => c.Identificador)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(x => x.Venda)
                .WithMany(x => x.ListaPromissoria)
                .HasForeignKey(x => x.IdentificadorVenda);

            Property(t => t.ValorPorExtenso)
                .HasMaxLength(100)
                .IsOptional();
        }
    }
}
