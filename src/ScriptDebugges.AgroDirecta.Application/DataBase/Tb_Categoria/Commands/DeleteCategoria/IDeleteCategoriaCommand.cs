using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Commands.DeleteCategoria
{
    public interface IDeleteCategoriaCommand
    {
        Task<bool> Execute(int idCategoria);
    }
}
