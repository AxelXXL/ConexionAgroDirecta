using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tbl_Categoria;

namespace ScriptDebugges.AgroDirecta.Persistence.Configuration
{
    public class Tb_CategoriaConfiguration
    {
        public Tb_CategoriaConfiguration(EntityTypeBuilder<Tb_CategoriaEntity> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.ID_Categoria);
            entityTypeBuilder.Property(x => x.Categoria).IsRequired();
            entityTypeBuilder.Property(x => x.Descripcion).IsRequired();

            entityTypeBuilder.HasMany(x => x.Productos)
                .WithOne(x => x.Categoria)
                .HasForeignKey(x => x.ID_Producto);
        }
    }
}
