using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Producto;

namespace ScriptDebugges.AgroDirecta.Domain.Entities.Tbl_Categoria
{
    public class Tb_CategoriaEntity
    {
        public int ID_Categoria { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }

        public ICollection<Tb_ProductoEntity> Productos { get; set; }


    }
}
