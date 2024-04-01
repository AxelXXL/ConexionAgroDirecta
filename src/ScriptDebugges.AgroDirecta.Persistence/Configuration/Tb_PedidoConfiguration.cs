using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Pedido;

namespace ScriptDebugges.AgroDirecta.Persistence.Configuration
{
    public class Tb_PedidoConfiguration
    {
        public Tb_PedidoConfiguration(EntityTypeBuilder<Tb_PedidoEntity> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.ID_Pedido);
            entityTypeBuilder.Property(x => x.ID_Usuario_Comprador).IsRequired();
            entityTypeBuilder.Property(x => x.ID_Usuario_Vendedor).IsRequired();
            entityTypeBuilder.Property(x => x.ID_Producto).IsRequired();
            entityTypeBuilder.Property(x => x.Cantidad).IsRequired();
            entityTypeBuilder.Property(x => x.Fecha_Pedido).IsRequired();
            entityTypeBuilder.Property(x => x.Estado_Pedido).IsRequired();
            entityTypeBuilder.Property(x => x.Metodo_Pago).IsRequired();
            entityTypeBuilder.Property(x => x.Direccion_Envio).IsRequired();

            entityTypeBuilder.HasOne(x => x.UsuarioComprador)
                .WithMany(x => x.PedidosComprador)
                .HasForeignKey(x => x.ID_Usuario_Comprador);

            entityTypeBuilder.HasOne(x => x.UsuarioVendedor)
                .WithMany(x => x.PedidosVendedor)
                .HasForeignKey(x => x.ID_Usuario_Vendedor);

            entityTypeBuilder.HasMany(x => x.Productos)
                .WithOne(x => x.Pedido)
                .HasForeignKey(x => x.ID_Producto);
        }
    }
}
