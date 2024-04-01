using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Prediccion;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Usuario;

namespace ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Cultivo
{
    public class Tb_CultivoEntity
    {
        public int ID_Cultivo { get; set; }
        public int ID_Usuario { get; set; }
        public string Nombre_Cultivo { get; set; }
        public DateTime Fecha_Siembra { get; set; }
        public DateTime Fecha_Cosecha { get; set; }
        public decimal Area_Cultivada { get; set; }
        public string Estado_Cultivo { get; set; }
        public Tb_UsuarioEntity Usuario {  get; set; }
        public ICollection<Tb_PrediccionEntity> Predicciones { get; set;}
    }
}
