using AutoMapper;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Commands.UpdateCategoria;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Commands.CreateProductos;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Producto;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tbl_Categoria;

namespace ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Commands.UpdateProducto
{
    public class UpdateProductoCommand : IUpdateProductoCommand
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;

        public UpdateProductoCommand(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }
        public async Task<UpdateProductoModel> Execute(UpdateProductoModel model)
        {
            var entity = _mapper.Map<Tb_ProductoEntity>(model);
            _dataBaseService.Tb_Producto.Update(entity);
            await _dataBaseService.SaveAsync();
            return model;
        }
    }
}
