namespace ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Queries.GetAllCategoria
{
    public interface IGetAllCategoriaQuery
    {
        Task<List<GetAllCategoriaModel>> Execute();
    }
}
