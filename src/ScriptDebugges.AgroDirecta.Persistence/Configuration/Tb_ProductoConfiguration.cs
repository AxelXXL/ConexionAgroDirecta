using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Producto;

namespace ScriptDebugges.AgroDirecta.Persistence.Configuration
{
    public class Tb_ProductoConfiguration
    {
        public Tb_ProductoConfiguration(EntityTypeBuilder<Tb_ProductoEntity> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.ID_Producto);
            entityTypeBuilder.Property(x => x.Nombre_Producto).IsRequired();
            entityTypeBuilder.Property(x => x.Descripcion).IsRequired();
            entityTypeBuilder.Property(x => x.Precio_Producto).IsRequired();
            entityTypeBuilder.Property(x => x.ID_Categoria).IsRequired();
            entityTypeBuilder.Property(x => x.ID_Usuario).IsRequired();
            entityTypeBuilder.Property(x => x.ID_UnidadMedida).IsRequired();
            entityTypeBuilder.Property(x => x.Stock).IsRequired();
            entityTypeBuilder.Property(x => x.Imagen_Producto).IsRequired();
            entityTypeBuilder.Property(x => x.activo).IsRequired();

            entityTypeBuilder.HasOne(x => x.Categoria)
               .WithMany(x => x.Productos)
               .HasForeignKey(x => x.ID_Categoria);

            entityTypeBuilder.HasOne(x => x.Usuario)
                .WithMany(x => x.Productos)
                .HasForeignKey(x => x.ID_Usuario);

            entityTypeBuilder.HasOne(x => x.UnidadMedida)
                .WithMany(x => x.Productos)
                .HasForeignKey(x => x.ID_UnidadMedida);

            entityTypeBuilder.HasOne(x => x.Pedido)
                .WithMany(x => x.Productos)
                .HasForeignKey(x => x.ID_Producto);
        }
    }
}
