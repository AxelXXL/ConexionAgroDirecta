namespace ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Commands.UpdateCategoria
{
    public interface IUpdateCategoriaCommand
    {
        Task<UpdateCategoriaModel> Execute(UpdateCategoriaModel model);
    }
}
