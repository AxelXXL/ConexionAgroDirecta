using AutoMapper;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tbl_Categoria;

namespace ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Commands.CreateCategoria
{
    public class CreateCategoriaModel 
    {
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
    }
}
