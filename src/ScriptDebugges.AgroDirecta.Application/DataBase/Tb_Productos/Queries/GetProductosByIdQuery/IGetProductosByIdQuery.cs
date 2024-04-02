namespace ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Queries.GetProductosByIdQuery
{
    public interface IGetProductosByIdQuery
    {
        Task<List<GetProductosByIdModel>> Execute(int idProducto);
    }
}
