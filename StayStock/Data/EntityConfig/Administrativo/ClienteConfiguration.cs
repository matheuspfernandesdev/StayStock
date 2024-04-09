using Dominio.Entities.Administrativo;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.EntityConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(x => x.Identificador);

            Property(c => c.Identificador)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnOrder(1);

            HasOptional(x => x.Endereco)
                .WithMany(x => x.Cliente)
                .HasForeignKey(x => x.EnderecoIdentificador);

            Property(t => t.Nome)
                .HasMaxLength(200)
                .IsRequired()
                .HasColumnOrder(2);

            Property(t => t.Telefone)
                .HasMaxLength(30)
                .IsOptional();

            Property(t => t.CodigoCpfCnpj)
                .HasMaxLength(30)
                .IsOptional();

            Property(t => t.Email)
                .HasMaxLength(50)
                .IsOptional();

            Property(t => t.Identidade)
                .HasMaxLength(30)
                .IsOptional();

            Property(t => t.DataNascimento)
                .IsOptional();

            //ESSE METODO DEU RUIM TB
            //HasOptional(x => x.Endereco)
            //    .WithRequired(x => x.Cliente);

            //SEGUINDO A LOGICA DAS LISTAS DE ENDERECOS POR ENTIDADE (DEU RUIM)
            //HasMany(x => x.Enderecos)
            //    .WithRequired(x => x.Cliente)
            //    .HasForeignKey(x => x.IdentificadorCliente);
        }
    }
}
