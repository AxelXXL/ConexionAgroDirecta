using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Pedido;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_UnidadMedida;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Usuario;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tbl_Categoria;

namespace ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Producto
{
    public class Tb_ProductoEntity
    {
        public int ID_Producto { get; set; }
        public string Nombre_Producto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio_Producto { get; set; }
        public int ID_Categoria { get; set; }
        public int ID_Usuario { get; set; }
        public int ID_UnidadMedida { get; set; }
        public int Stock { get; set; }
        public string Imagen_Producto { get; set; }
        public bool activo { get; set; }
        public Tb_CategoriaEntity Categoria { get; set; }
        public Tb_UsuarioEntity Usuario { get; set; }
        public Tb_UnidadMedidaEntity UnidadMedida { get; set; }
        public Tb_PedidoEntity Pedido { get; set; }
    }
}
