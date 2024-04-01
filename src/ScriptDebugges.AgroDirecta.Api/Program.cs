using ScriptDebugges.AgroDirecta.Api;
using ScriptDebugges.AgroDirecta.Application;
using ScriptDebugges.AgroDirecta.External;
using ScriptDebugges.AgroDirecta.Persistence;

var builder = WebApplication.CreateBuilder(args);

//TRAER TODOS LOS SERVICIOS
builder.Services.AddWebApi()
    .AddApplication()
    .AddExternal(builder.Configuration)
    .AddPersistence(builder.Configuration);
builder.Services.AddControllers();


var app = builder.Build();
app.MapControllers();
app.Run();
