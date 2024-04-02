namespace ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Queries.GetAllProductosQuery
{
    public class GetAllProductosModel
    {
        public int ID_Producto { get; set; }
        public string Nombre_Producto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio_Producto { get; set; }
        public string Categoria { get; set; }
        public string Usuario { get; set; }
        public string UnidadMedida { get; set; }
        public int Stock { get; set; }
        public string Imagen_Producto { get; set; }
        public bool activo { get; set; }
    }
}
