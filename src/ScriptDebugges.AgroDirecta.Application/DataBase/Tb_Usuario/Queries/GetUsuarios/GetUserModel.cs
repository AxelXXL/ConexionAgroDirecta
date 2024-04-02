using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Usuario.Queries.GetUsuarios
{
    public class GetUserModel
    {
    }

    public class LoginValidateRequestModel
    {
        public string Correo { get; set; }
        public string Contraseña { get; set; }
    }

    public class LoginValidateResponseModel
    {
        public string Nombre_Usuario { get; set; }
        public int ID_Rol { get; set; }
    }
}
