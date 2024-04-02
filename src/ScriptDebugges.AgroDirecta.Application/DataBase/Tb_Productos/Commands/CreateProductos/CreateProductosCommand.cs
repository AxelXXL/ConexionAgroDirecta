using AutoMapper;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Commands.CreateCategoria;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Producto;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tbl_Categoria;

namespace ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Commands.CreateProductos
{
    public class CreateProductosCommand : ICreateProductosCommand
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;

        public CreateProductosCommand(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }
        public async Task<CreateProductosModel> Execute(CreateProductosModel model)
        {
            var entity = _mapper.Map<Tb_ProductoEntity>(model);
            await _dataBaseService.Tb_Producto.AddAsync(entity);
            await _dataBaseService.SaveAsync();
            return model;
        }
    }
}
