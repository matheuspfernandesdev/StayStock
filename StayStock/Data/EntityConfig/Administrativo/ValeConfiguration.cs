using Dominio.Entities.Administrativo;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.EntityConfig.Administrativo
{
    public class ValeConfiguration : EntityTypeConfiguration<Vale>
    {
        public ValeConfiguration()
        {
            HasKey(x => x.Identificador);

            Property(c => c.Identificador)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(x => x.FuncionarioVale)
                .WithMany(x => x.ListaVales)
                .HasForeignKey(x => x.IdentificadorFuncionarioVale);

            Property(t => t.Descricao)
                .HasMaxLength(2000)
                .IsOptional();
        }
    }
}
