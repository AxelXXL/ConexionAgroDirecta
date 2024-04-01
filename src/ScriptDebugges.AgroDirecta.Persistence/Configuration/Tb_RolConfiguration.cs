using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tbl_Rol;

namespace ScriptDebugges.AgroDirecta.Persistence.Configuration
{
    public class Tb_RolConfiguration
    {
        public Tb_RolConfiguration(EntityTypeBuilder<Tb_RolEntity> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.ID_Rol);
            entityTypeBuilder.Property(x => x.TipoRol).IsRequired();
            entityTypeBuilder.Property(x => x.Descripcion).IsRequired();

            entityTypeBuilder.HasMany(x => x.Usuarios)
                .WithOne(x => x.Rol)
                .HasForeignKey(x => x.ID_ROL);
        }
    }
}
