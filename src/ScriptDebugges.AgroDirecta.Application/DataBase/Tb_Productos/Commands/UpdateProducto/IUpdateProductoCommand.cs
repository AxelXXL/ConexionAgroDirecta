namespace ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Commands.UpdateProducto
{
    public interface IUpdateProductoCommand 
    {
        Task<UpdateProductoModel> Execute(UpdateProductoModel model);
    }
}
