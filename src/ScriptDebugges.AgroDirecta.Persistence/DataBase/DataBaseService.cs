using Microsoft.EntityFrameworkCore;
using ScriptDebugges.AgroDirecta.Application.DataBase;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Cultivo;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Pedido;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Prediccion;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Producto;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_UnidadMedida;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Usuario;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tbl_Categoria;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tbl_Rol;
using ScriptDebugges.AgroDirecta.Persistence.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptDebugges.AgroDirecta.Persistence.DataBase
{
    public class DataBaseService : DbContext, IDataBaseService
    {
        public DataBaseService(DbContextOptions options): base(options)
        {
            
        }
        //ENTIDADES DE BASE DE DATOS MAPEARLAS A LAS ENTIDADES
        public DbSet<Tb_CategoriaEntity> Tb_Categoria { get; set; }
        public DbSet<Tb_CultivoEntity> Tb_Cultivo { get; set; }
        public DbSet<Tb_PedidoEntity> Tb_Pedido { get; set; }
        public DbSet<Tb_PrediccionEntity> Tb_Prediccion { get; set; }
        public DbSet<Tb_ProductoEntity> Tb_Producto { get; set; }
        public DbSet<Tb_RolEntity> Tb_Rol { get; set; }
        public DbSet<Tb_UnidadMedidaEntity> Tb_UnidadMedida { get; set; }
        public DbSet<Tb_UsuarioEntity> Tb_Usuario { get; set; }

        //METODO PARA GUARDAR
        public async Task<bool> SaveAsync()
        {
            return await SaveChangesAsync() > 0;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EntityConfiguration(modelBuilder);
        }

        //APLICAR LAS CONFIGURACIONES DE ENTIDADES
        private void EntityConfiguration(ModelBuilder modelBuilder)
        {
            new Tb_CategoriaConfiguration(modelBuilder.Entity<Tb_CategoriaEntity>());
            new Tb_CultivoConfiguration(modelBuilder.Entity<Tb_CultivoEntity>());
            new Tb_PedidoConfiguration(modelBuilder.Entity<Tb_PedidoEntity>());
            new Tb_PrediccionConfiguration(modelBuilder.Entity<Tb_PrediccionEntity>());
            new Tb_ProductoConfiguration(modelBuilder.Entity<Tb_ProductoEntity>());
            new Tb_RolConfiguration(modelBuilder.Entity<Tb_RolEntity>());
            new Tb_UnidadMedidaConfiguration(modelBuilder.Entity<Tb_UnidadMedidaEntity>());
            new Tb_UsuarioConfiguration(modelBuilder.Entity<Tb_UsuarioEntity>());
        }
    }
}
