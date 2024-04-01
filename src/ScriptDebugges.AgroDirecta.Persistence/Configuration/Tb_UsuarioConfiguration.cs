using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptDebugges.AgroDirecta.Persistence.Configuration
{
    public class Tb_UsuarioConfiguration
    {
        public Tb_UsuarioConfiguration(EntityTypeBuilder<Tb_UsuarioEntity> entityTypeBuilder) 
        {
            entityTypeBuilder.HasKey(x => x.ID_Usuario);
            entityTypeBuilder.Property(x => x.NombreUsuario).IsRequired();
            entityTypeBuilder.Property(x => x.Correo).IsRequired();
            entityTypeBuilder.Property(x => x.Contrasena).IsRequired();
            entityTypeBuilder.Property(x => x.ID_ROL).IsRequired();
            entityTypeBuilder.Property(x => x.Telefono).IsRequired();
            entityTypeBuilder.Property(x => x.Ubicacion).IsRequired();
            entityTypeBuilder.Property(x => x.Imagen_Perfil).IsRequired();
            entityTypeBuilder.Property(x => x.Imagen_Perfil).IsRequired();
            entityTypeBuilder.Property(x => x.Activo).IsRequired();

            entityTypeBuilder.HasOne(x => x.Rol)
                .WithMany(x => x.Usuarios)
                .HasForeignKey(x=>x.ID_ROL);

            entityTypeBuilder.HasMany(x => x.Productos)
                .WithOne(x => x.Usuario)
                .HasForeignKey(x => x.ID_Usuario);

            entityTypeBuilder.HasMany(x => x.PedidosComprador)
                .WithOne(x => x.UsuarioComprador)
                .HasForeignKey(x => x.ID_Usuario_Comprador);

            entityTypeBuilder.HasMany(x => x.PedidosVendedor)
                .WithOne(x => x.UsuarioVendedor)
                .HasForeignKey(x => x.ID_Usuario_Vendedor);

            entityTypeBuilder.HasMany(x => x.Cultivos)
                .WithOne(x => x.Usuario)
                .HasForeignKey(x => x.ID_Usuario);
        }
    }
}
