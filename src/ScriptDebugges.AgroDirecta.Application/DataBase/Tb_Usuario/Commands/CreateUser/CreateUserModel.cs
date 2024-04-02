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
        public string NombreUsuario { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public int ID_ROL { get; set; }
        public string Telefono { get; set; }
        public string Ubicacion { get; set; }
        public string Imagen_Perfil { get; set; }
        public bool Activo { get; set; }
    }
}
