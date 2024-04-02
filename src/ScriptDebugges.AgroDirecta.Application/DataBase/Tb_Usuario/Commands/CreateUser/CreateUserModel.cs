using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Usuario.Commands.CreateUser
{
    public class CreateUserModel
    {
    }

    public class CreateUserModelResponse
    {
        public string Nombre_Usuario { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public string ConfirmarContrasena { get; set; }
        public int ID_Rol { get; set; }
        public string Telefono { get; set; }
        public string Ubicacion { get; set; }
        public byte[]? Imagen_Perfil { get; set; }
    }
}
