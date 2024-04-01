using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Usuario;

namespace ScriptDebugges.AgroDirecta.Domain.Entities.Tbl_Rol
{
    public class Tb_RolEntity
    {
        public int ID_Rol { get; set; }
        public string TipoRol { get; set; }
        public string Descripcion { get; set; }

        public ICollection<Tb_UsuarioEntity > Usuarios { get; set; }
    }
}
