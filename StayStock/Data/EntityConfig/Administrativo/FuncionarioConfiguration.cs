using Dominio.Entities.Administrativo;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.EntityConfig.Administrativo
{
    public class FuncionarioConfiguration : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioConfiguration()
        {
            HasKey(x => x.Identificador);

            Property(c => c.Identificador)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnOrder(1);

            HasOptional(x => x.Endereco)
                .WithMany(x => x.Funcionario)
                .HasForeignKey(x => x.EnderecoIdentificador);

            Property(t => t.Nome)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnOrder(2);

            Property(t => t.Senha)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnOrder(3);

            Property(t => t.CargaHoraria)
                .HasMaxLength(100)
                .IsRequired();

            Property(t => t.NumeroCarteiraTrabalho)
                .HasColumnType("bigint")
                .IsOptional();

            Property(t => t.NumeroPIS)
                .HasColumnType("bigint")
                .IsOptional();

            Property(t => t.IndicadorTipoFuncionario)
                .IsRequired();

            Property(t => t.CodigoCpfCnpj)
                .HasMaxLength(30)
                .IsOptional();

            Property(t => t.Identidade)
                .HasMaxLength(30)
                .IsOptional();

            Property(t => t.Telefone)
                .HasMaxLength(30)
                .IsOptional();

            Property(t => t.Email)
                .HasMaxLength(50)
                .IsOptional();

            //DEU RUIM TB
            //HasOptional(x => x.Endereco)
            //    .WithRequired(x => x.Funcionario);

            //SEGUINDO A LOGICA DAS LISTAS DE ENDERECOS POR ENTIDADE
            //HasMany(x => x.Enderecos)
            //.WithRequired(x => x.Funcionario)
            //.HasForeignKey(x => x.IdentificadorFuncionario);
        }
    }
}
