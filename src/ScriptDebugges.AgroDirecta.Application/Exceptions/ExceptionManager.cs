using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ScriptDebugges.AgroDirecta.Application.Features;

namespace ScriptDebugges.AgroDirecta.Application.Exceptions
{
    public class ExceptionManager : IExceptionFilter
    {
        //EXCEPCIONES PERSONALIZADAS, SE UTILIZA EL SERVICIO DE RESPUESTA PARA APIS.
        public void OnException(ExceptionContext context)
        {
            context.Result = new ObjectResult(ResponseApiService.Response(
                StatusCodes.Status500InternalServerError, null, context.Exception.Message));

            context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
        }
    }
}
