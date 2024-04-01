using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Cultivo;

namespace ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Prediccion
{
    public class Tb_PrediccionEntity
    {
        public int ID_Prediccion { get; set; }
        public int ID_Producto { get; set; }
        public int ID_Cultivo { get; set; }
        public DateTime Fecha_Prediccion { get; set; }
        public string Descripcion { get; set; }
        public Tb_CultivoEntity Cultivo { get; set; }
    }
}
