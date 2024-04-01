using AutoMapper;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Commands.CreateCategoria;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Commands.UpdateCategoria;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Queries.GetAllCategoria;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tbl_Categoria;

namespace ScriptDebugges.AgroDirecta.Application.Configuration
{
    public class MapperProfile : Profile
    {
        //SE MAPEAN LAS ENTIDADES DE DOMAIN CON LAS DE LOS COMMANDS EN APPLICATION
        public MapperProfile()
        {
            CreateMap<Tb_CategoriaEntity, CreateCategoriaModel>().ReverseMap();
            CreateMap<Tb_CategoriaEntity, UpdateCategoriaModel>().ReverseMap();
            CreateMap<Tb_CategoriaEntity, GetAllCategoriaModel>().ReverseMap();
        }
    }
}
