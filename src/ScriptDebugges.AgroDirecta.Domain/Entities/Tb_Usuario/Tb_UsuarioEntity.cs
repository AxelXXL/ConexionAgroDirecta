﻿using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Cultivo;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Pedido;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Producto;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tbl_Rol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Usuario
{
    public class Tb_UsuarioEntity
    {
        public int ID_Usuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public int ID_ROL { get; set; }
        public string Telefono { get; set; }
        public string Ubicacion { get; set; }
        public string Imagen_Perfil { get; set; }
        public bool Activo { get; set; }
        public Tb_RolEntity Rol { get; set; }
        public ICollection<Tb_ProductoEntity> Productos { get; set; }
        public ICollection<Tb_PedidoEntity> PedidosVendedor { get; set; }
        public ICollection<Tb_PedidoEntity> PedidosComprador { get; set; }
        public ICollection<Tb_CultivoEntity> Cultivos { get; set; }

        public override bool Equals(object obj)
        {
            if(obj == null || GetType() != obj.GetType()) 
                return false;

            Tb_UsuarioEntity other = (Tb_UsuarioEntity) obj;
            return NombreUsuario == other.NombreUsuario &&
                Correo == other.Correo &&
                Contrasena == other.Contrasena &&
                ID_ROL == other.ID_ROL &&
                Telefono == other.Telefono &&
                Ubicacion == other.Ubicacion &&
                Imagen_Perfil == other.Imagen_Perfil &&
                Activo == other.Activo;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
