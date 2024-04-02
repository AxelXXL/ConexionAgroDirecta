using AutoMapper;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Commands.CreateCategoria;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Commands.UpdateCategoria;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Queries.GetAllCategoria;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Commands.CreateProductos;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Commands.UpdateProducto;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Queries.GetAllProductosQuery;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Queries.GetProductosByIdQuery;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Usuario.Commands.CreateUser;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Producto;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Usuario;
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
            CreateMap<Tb_ProductoEntity, IGetAllProductosQuery>().ReverseMap();
            CreateMap<Tb_ProductoEntity, IGetProductosByIdQuery>().ReverseMap();
            #endregion

            #region Tb_Usuario
            CreateMap<Tb_UsuarioEntity, CreateUserModelResponse>().ReverseMap();
            #endregion

            #region Tb_Pedido

            #endregion
        }
    }
}
