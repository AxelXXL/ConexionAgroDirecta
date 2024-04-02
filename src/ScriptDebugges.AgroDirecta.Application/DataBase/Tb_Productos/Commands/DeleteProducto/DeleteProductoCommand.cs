using Microsoft.EntityFrameworkCore;

namespace ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Commands.DeleteProducto
{
    public class DeleteProductoCommand : IDeleteProductoCommand
    {
        private readonly IDataBaseService _dataBaseService;

        public DeleteProductoCommand(IDataBaseService dataBaseService)
        {
            _dataBaseService = dataBaseService;
        }
        public async Task<bool> Execute(int idProducto)
        {
            var entity = await _dataBaseService.Tb_Producto.FirstOrDefaultAsync(x => x.ID_Categoria == idProducto);

            if (entity == null)
                return false;

            _dataBaseService.Tb_Producto. Remove(entity);
            return await _dataBaseService.SaveAsync();
        }
    }
}
