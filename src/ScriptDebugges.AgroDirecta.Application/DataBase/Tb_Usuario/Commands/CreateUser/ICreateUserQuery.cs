using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Usuario.Commands.CreateUser
{
    public interface ICreateUserQuery
    {
        Task<bool> Execute(CreateUserModelResponse newUser);
    }
}
