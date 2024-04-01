using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Foro;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_ForoUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptDebugges.AgroDirecta.Persistence.Configuration
{
    public class Tb_ForoUsuarioConfiguration
    {
        public Tb_ForoUsuarioConfiguration(EntityTypeBuilder<Tb_ForoUsuarioEntity> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.ID_Foro);
            entityTypeBuilder.Property(x => x.ID_Usuario);
        }
    }
}
