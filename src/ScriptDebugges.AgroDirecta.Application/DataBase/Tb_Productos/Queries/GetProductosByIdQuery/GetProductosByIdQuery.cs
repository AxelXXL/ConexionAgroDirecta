using Microsoft.EntityFrameworkCore;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Queries.GetAllProductosQuery;

namespace ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Queries.GetProductosByIdQuery
{
    public class GetProductosByIdQuery : IGetProductosByIdQuery
    {
        private readonly IDataBaseService _dataBaseService;

        public GetProductosByIdQuery(IDataBaseService dataBaseService)
        {
            _dataBaseService = dataBaseService;
        }

        public async Task<List<GetProductosByIdModel>> Execute(int idProducto)
        {
            var result = await(from Productos in _dataBaseService.Tb_Producto
                               join Categoria in _dataBaseService.Tb_Categoria
                               on Productos.ID_Categoria equals Categoria.ID_Categoria
                               join Usuario in _dataBaseService.Tb_Usuario
                               on Productos.ID_Usuario equals Usuario.ID_Usuario
                               join Unidad in _dataBaseService.Tb_UnidadMedida
                               on Productos.ID_UnidadMedida equals Unidad.ID_UnidadMedida
                               where Productos.ID_Producto == idProducto
                               select new GetProductosByIdModel
                               {
                                   ID_Producto = Productos.ID_Producto,
                                   Nombre_Producto = Productos.Nombre_Producto,
                                   Descripcion = Productos.Descripcion,
                                   Precio_Producto = Productos.Precio_Producto,
                                   Categoria = Categoria.Categoria,
                                   Usuario = Usuario.NombreUsuario,
                                   UnidadMedida = Unidad.Unidad,
                                   Stock = Productos.Stock,
                                   Imagen_Producto = Productos.Imagen_Producto,
                                   activo = Productos.activo
                               }).ToListAsync();
            return result;
        }
    }
}
