using Dominio.Entities.Administrativo;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.EntityConfig
{
    public class FabricaConfiguration : EntityTypeConfiguration<Fabrica>
    {
        public FabricaConfiguration()
        {
            HasKey(c => c.Identificador);

            Property(c => c.Identificador)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasOptional(x => x.Endereco)
                .WithMany(x => x.Fabrica)
                .HasForeignKey(x => x.EnderecoIdentificador);

            Property(t => t.Nome)
                .HasMaxLength(100)
                .IsRequired();

            Property(t => t.CNPJ)
                .HasMaxLength(30)
                .IsOptional();

            Property(t => t.Telefone)
                .HasMaxLength(25)
                .IsOptional();

            Property(t => t.Email)
                .HasMaxLength(50)
                .IsOptional();

            Property(t => t.Descricao)
                .HasMaxLength(2000)
                .IsOptional();

            //DEU RUIM TB
            //HasOptional(x => x.Endereco)
            //    .WithRequired(x => x.Fabrica);

            //SEGUINDO A LOGICA DAS LISTAS DE ENDERECOS POR ENTIDADE
            //HasMany(x => x.Enderecos)
            //.WithRequired(x => x.Fabrica)
            //.HasForeignKey(x => x.IdentificadorFabrica);
        }
    }
}
