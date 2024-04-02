namespace ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Queries.GetAllProductosQuery
{
    public interface IGetAllProductosQuery
    {
        Task<List<GetAllProductosModel>> Execute();
    }
}
