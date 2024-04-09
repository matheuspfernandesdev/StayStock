using Dominio.Entities.Administrativo;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.EntityConfig.Administrativo
{
    public class EmpresaLocalConfiguration : EntityTypeConfiguration<EmpresaLocal>
    {
        public EmpresaLocalConfiguration()
        {
            HasKey(x => x.Identificador);

            Property(c => c.Identificador)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            
            HasRequired(x => x.Endereco)
                .WithMany(x => x.EmpresaLocal)
                .HasForeignKey(x => x.EnderecoIdentificador);

            HasRequired(x => x.FuncionarioGestor)
                .WithMany(x => x.ListaEmpresaLocal)
                .HasForeignKey(x => x.IdentificadorFuncionarioGestor);

            Property(t => t.RazaoSocial)
                .HasMaxLength(100)
                .IsRequired();

            Property(t => t.NomeFantasia)
                .HasMaxLength(100)
                .IsOptional();

            Property(t => t.CNPJ)
                .HasMaxLength(30)
                .IsRequired();

            //DEU RUIM TB
            //HasOptional(x => x.Endereco)
            //    .WithRequired(x => x.EmpresaLocal);

            //SEGUINDO A LOGICA DAS LISTAS DE ENDERECOS POR ENTIDADE
            //HasMany(x => x.Enderecos)
            //    .WithRequired(x => x.EmpresaLocal)
            //    .HasForeignKey(x => x.IdentificadorEmpresaLocal);
        }
    }
}
