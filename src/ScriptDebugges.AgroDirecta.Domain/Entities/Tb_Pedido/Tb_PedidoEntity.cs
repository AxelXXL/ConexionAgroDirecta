using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Producto;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Pedido
{
    public class Tb_PedidoEntity
    {
        public int ID_Pedido { get; set; }
        public int ID_Usuario_Comprador { get; set; }
        public int ID_Usuario_Vendedor { get; set; }
        public int ID_Producto { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha_Pedido { get; set; }
        public string Estado_Pedido { get; set; }
        public string Metodo_Pago { get; set; }
        public string Direccion_Envio { get; set; }
        public Tb_UsuarioEntity UsuarioComprador { get; set; }  
        public Tb_UsuarioEntity UsuarioVendedor { get; set; }
        public ICollection<Tb_ProductoEntity> Productos { get; set; }
    }
}
