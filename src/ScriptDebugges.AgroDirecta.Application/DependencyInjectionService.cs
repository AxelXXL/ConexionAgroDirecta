﻿using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using ScriptDebugges.AgroDirecta.Application.Configuration;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Commands.CreateCategoria;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Commands.DeleteCategoria;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Commands.UpdateCategoria;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Queries.GetAllCategoria;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Commands.CreateProductos;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Commands.DeleteProducto;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Commands.UpdateProducto;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Queries.GetAllProductosQuery;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Queries.GetProductosByIdQuery;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Usuario.Commands.CreateUser;
using ScriptDebugges.AgroDirecta.Application.SecurityEncrypt;
using ScriptDebugges.AgroDirecta.Application.Validators.Categoria;

namespace ScriptDebugges.AgroDirecta.Application
{
    public static class DependencyInjectionService
    {
        //SERVICIO DE MAPPER
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var mapper = new MapperConfiguration(config =>
            {
                config.AddProfile(new MapperProfile());
            });

            services.AddSingleton(mapper.CreateMapper());
            //MAPEAR LAS ENTIDADES DE COMMANDS Y QUERIES
            #region Categorias
            services.AddTransient<ICreateCategoriaCommand, CreateCategoriaCommand>();
            services.AddTransient<IUpdateCategoriaCommand, UpdateCategoriaCommand>();
            services.AddTransient<IDeleteCategoriaCommand, DeleteCategoriaCommand>();
            services.AddTransient<IGetAllCategoriaQuery, GetAllCategoriaQuery>();
            #endregion

            #region Productos
            services.AddTransient<ICreateProductosCommand, CreateProductosCommand>();
            services.AddTransient<IUpdateProductoCommand, UpdateProductoCommand>();
            services.AddTransient<IDeleteProductoCommand, DeleteProductoCommand>();
            services.AddTransient<IGetAllProductosQuery, GetAllProductosQuery>();
            services.AddTransient<IGetProductosByIdQuery, GetProductosByIdQuery>();
            #endregion

            #region Usuarios
            services.AddTransient<ICreateUserQuery, CreateUserQuery>();
            #endregion

            #region
            services.AddTransient<ICreateUserQuery, CreateUserQuery>();
            #endregion

            #region Validators
            services.AddScoped<IValidator<CreateCategoriaModel>, CreateCategoriaValidator>();
            #endregion


            #region Security
            services.AddTransient<Security>();
            #endregion
            return services;
        }
    }
}
