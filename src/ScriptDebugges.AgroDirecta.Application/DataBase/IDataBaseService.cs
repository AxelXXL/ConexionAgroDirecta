using Microsoft.EntityFrameworkCore;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Cultivo;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Pedido;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Prediccion;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Producto;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_UnidadMedida;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Usuario;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tbl_Categoria;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tbl_Rol;

namespace ScriptDebugges.AgroDirecta.Application.DataBase
{
    //INTERFAZ DEL SERVICIO DE BD
    public interface IDataBaseService
    {
        DbSet<Tb_CategoriaEntity> Tb_Categoria { get; set; }
        DbSet<Tb_CultivoEntity> Tb_Cultivo { get; set; }
        DbSet<Tb_PedidoEntity> Tb_Pedido { get; set; }
        DbSet<Tb_PrediccionEntity> Tb_Prediccion { get; set; }
        DbSet<Tb_ProductoEntity> Tb_Producto { get; set; }
        DbSet<Tb_RolEntity> Tb_Rol { get; set; }
        DbSet<Tb_UnidadMedidaEntity> Tb_UnidadMedida { get; set; }
        DbSet<Tb_UsuarioEntity> Tb_Usuario { get; set; }
        Task<bool> SaveAsync();
    }
}
