using Microsoft.EntityFrameworkCore;

namespace ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Commands.DeleteCategoria
{
    public class DeleteCategoriaCommand : IDeleteCategoriaCommand
    {
        private readonly IDataBaseService _dataBaseService;

        public DeleteCategoriaCommand(IDataBaseService dataBaseService)
        {
            _dataBaseService = dataBaseService;
        }

        public async Task<bool> Execute(int idCategoria)
        {
            var entity = await _dataBaseService.Tb_Categoria.FirstOrDefaultAsync(x => x.ID_Categoria == idCategoria);

            if (entity == null)
                return false;

            _dataBaseService.Tb_Categoria.Remove(entity);
            return await _dataBaseService.SaveAsync();
        }
    }
}
