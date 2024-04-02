namespace ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Commands.DeleteProducto
{
    public interface IDeleteProductoCommand
    {
        Task<bool> Execute(int idProducto);
    }
}
