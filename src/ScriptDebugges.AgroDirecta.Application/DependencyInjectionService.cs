using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using ScriptDebugges.AgroDirecta.Application.Configuration;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Commands.CreateCategoria;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Commands.DeleteCategoria;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Commands.UpdateCategoria;
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
            #endregion

            #region Validators
            services.AddScoped<IValidator<CreateCategoriaModel>, CreateCategoriaValidator>();
            #endregion

            #region Token

            #endregion
            return services;
        }
    }
}
