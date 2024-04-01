using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ScriptDebugges.AgroDirecta.Application.DataBase;
using ScriptDebugges.AgroDirecta.Persistence.DataBase;

namespace ScriptDebugges.AgroDirecta.Persistence
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            //SERVICIO CONEXION A BASE DE DATOS
            services.AddDbContext<DataBaseService>(options =>
            options.UseSqlServer(configuration["SQLConnectionString"]));

            services.AddScoped<IDataBaseService, DataBaseService>();
            return services;
        }
    }
}
