using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Producto;

namespace ScriptDebugges.AgroDirecta.Domain.Entities.Tb_UnidadMedida
{
    public class Tb_UnidadMedidaEntity
    {
        public int ID_UnidadMedida { get; set; }
        public string Unidad { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Tb_ProductoEntity> Productos { get; set; }
    }
}
