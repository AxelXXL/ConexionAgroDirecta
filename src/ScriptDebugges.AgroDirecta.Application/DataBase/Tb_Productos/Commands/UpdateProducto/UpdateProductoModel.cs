namespace ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Commands.UpdateProducto
{
    public class UpdateProductoModel
    {
        public int ID_Producto { get; set; }
        public string Nombre_Producto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio_Producto { get; set; }
        public int ID_Categoria { get; set; }
        public int ID_Usuario { get; set; }
        public int ID_UnidadMedida { get; set; }
        public int Stock { get; set; }
        public string Imagen_Producto { get; set; }
        public bool activo { get; set; }
    }
}
