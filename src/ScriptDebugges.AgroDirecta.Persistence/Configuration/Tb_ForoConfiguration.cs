using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Foro;

namespace ScriptDebugges.AgroDirecta.Persistence.Configuration
{
    public class Tb_ForoConfiguration
    {
        public Tb_ForoConfiguration(EntityTypeBuilder<Tb_ForoEntity> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.ID_Foro);
            entityTypeBuilder.Property(x => x.Titulo).IsRequired();
            entityTypeBuilder.Property(x => x.Descripcion).IsRequired();
            entityTypeBuilder.Property(x => x.Fecha_Creacion).IsRequired();
            entityTypeBuilder.Property(x => x.Activo).IsRequired();
        }
    }
}
