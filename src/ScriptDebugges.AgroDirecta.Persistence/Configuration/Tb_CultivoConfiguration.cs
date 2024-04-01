using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Cultivo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptDebugges.AgroDirecta.Persistence.Configuration
{
    public class Tb_CultivoConfiguration
    {
        public Tb_CultivoConfiguration(EntityTypeBuilder<Tb_CultivoEntity> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.ID_Cultivo);
            entityTypeBuilder.Property(x => x.ID_Usuario).IsRequired();
            entityTypeBuilder.Property(x => x.Nombre_Cultivo).IsRequired();
            entityTypeBuilder.Property(x => x.Fecha_Siembra).IsRequired();
            entityTypeBuilder.Property(x => x.Fecha_Cosecha).IsRequired();
            entityTypeBuilder.Property(x => x.Area_Cultivada).IsRequired();
            entityTypeBuilder.Property(x => x.Estado_Cultivo).IsRequired();

            entityTypeBuilder.HasOne(x => x.Usuario)
                .WithMany(x => x.Cultivos)
                .HasForeignKey(x => x.ID_Usuario);

            entityTypeBuilder.HasMany(x => x.Predicciones)
                .WithOne(x => x.Cultivo)
                .HasForeignKey(x => x.ID_Cultivo);
        }
    }
}
