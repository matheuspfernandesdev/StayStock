using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.EntityConfig.Administrativo
{
    public class VendaConfiguration : EntityTypeConfiguration<Dominio.Entities.Vendas.Venda>
    {
        public VendaConfiguration()
        {
            HasKey(x => x.Identificador);

            Property(c => c.Identificador)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnOrder(1);

            HasRequired(x => x.Cliente)
                .WithMany(x => x.ListaVendas)
                .HasForeignKey(x => x.IdentificadorCliente);

            HasRequired(x => x.Funcionario)
                .WithMany(x => x.ListaVendas)
                .HasForeignKey(x => x.IdentificadorFuncionario);

            HasOptional(x => x.Endereco)
                .WithMany(x => x.Venda)
                .HasForeignKey(x => x.EnderecoIdentificador);

            Property(t => t.Observacoes)
                .HasMaxLength(1000)
                .IsOptional();

            Property(t => t.DataHoraEntrega)
                .IsOptional();

            Property(t => t.QuantidadePromissoria)
                .IsOptional();

            //DEU RUIM TB
            //HasOptional(x => x.Endereco)
            //    .WithRequired(x => x.Venda);

            //SEGUINDO A LOGICA DAS LISTAS DE ENDERECOS POR ENTIDADE
            //HasMany(x => x.Enderecos)
            //    .WithRequired(x => x.Venda)
            //    .HasForeignKey(x => x.IdentificadorVenda);
        }
    }
}
