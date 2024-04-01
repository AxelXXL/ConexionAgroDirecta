using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Prediccion;

namespace ScriptDebugges.AgroDirecta.Persistence.Configuration
{
    public class Tb_PrediccionConfiguration
    {
        public Tb_PrediccionConfiguration(EntityTypeBuilder<Tb_PrediccionEntity> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.ID_Prediccion);
            entityTypeBuilder.Property(x => x.ID_Producto).IsRequired();
            entityTypeBuilder.Property(x => x.ID_Cultivo).IsRequired();
            entityTypeBuilder.Property(x => x.Fecha_Prediccion).IsRequired();
            entityTypeBuilder.Property(x => x.Descripcion).IsRequired();

            entityTypeBuilder.HasOne(x => x.Cultivo)
                .WithMany(x => x.Predicciones)
                .HasForeignKey(x => x.ID_Cultivo);
        }
    }
}
