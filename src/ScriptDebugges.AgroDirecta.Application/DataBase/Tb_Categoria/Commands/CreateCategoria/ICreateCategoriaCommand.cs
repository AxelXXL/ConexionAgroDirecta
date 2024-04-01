namespace ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Commands.CreateCategoria
{
    public interface ICreateCategoriaCommand
    {
        Task<CreateCategoriaModel> Execute(CreateCategoriaModel model);
    }
}
