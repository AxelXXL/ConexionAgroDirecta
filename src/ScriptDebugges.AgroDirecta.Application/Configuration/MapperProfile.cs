using AutoMapper;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Commands.CreateCategoria;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Commands.UpdateCategoria;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Queries.GetAllCategoria;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Commands.CreateProductos;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Commands.UpdateProducto;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Producto;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tbl_Categoria;

namespace ScriptDebugges.AgroDirecta.Application.Configuration
{
    public class MapperProfile : Profile
    {
        //SE MAPEAN LAS ENTIDADES DE DOMAIN CON LAS DE LOS COMMANDS EN APPLICATION
        public MapperProfile()
        {
            #region Tb_Categoria
            CreateMap<Tb_CategoriaEntity, CreateCategoriaModel>().ReverseMap();
            CreateMap<Tb_CategoriaEntity, UpdateCategoriaModel>().ReverseMap();
            CreateMap<Tb_CategoriaEntity, GetAllCategoriaModel>().ReverseMap();
            #endregion
            #region Tb_Producto
            CreateMap<Tb_ProductoEntity, CreateProductosModel>().ReverseMap();
            CreateMap<Tb_ProductoEntity, UpdateProductoModel>().ReverseMap();
            #endregion
        }
    }
}
