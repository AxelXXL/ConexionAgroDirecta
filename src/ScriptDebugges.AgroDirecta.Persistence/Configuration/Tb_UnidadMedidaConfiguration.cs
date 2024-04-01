using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_UnidadMedida;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptDebugges.AgroDirecta.Persistence.Configuration
{
    public class Tb_UnidadMedidaConfiguration
    {
        public Tb_UnidadMedidaConfiguration(EntityTypeBuilder<Tb_UnidadMedidaEntity> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.ID_UnidadMedida);
            entityTypeBuilder.Property(x => x.Unidad).IsRequired();
            entityTypeBuilder.Property(x => x.Descripcion).IsRequired();

            entityTypeBuilder.HasMany(x => x.Productos)
               .WithOne(x => x.UnidadMedida)
               .HasForeignKey(x => x.ID_Producto);
        }
    }
}
