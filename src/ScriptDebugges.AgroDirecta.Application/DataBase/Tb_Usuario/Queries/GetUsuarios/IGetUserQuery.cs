using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Usuario.Queries.GetUsuarios
{
    public interface IGetUserQuery
    {
        Task<LoginValidateResponseModel> Execute(LoginValidateRequestModel user);
    }
}
