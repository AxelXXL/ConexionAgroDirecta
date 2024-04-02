namespace ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Commands.CreateProductos
{
    public interface ICreateProductosCommand
    {
        Task<CreateProductosModel> Execute(CreateProductosModel model);
    }
}
