using System.Web.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using ScriptDebugges.AgroDirecta.Api.Services;

namespace ScriptDebugges.AgroDirecta.Api.Services
{
    public class Auth : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext.HttpContext.Request.Headers.Authorization == 0)
            {
                throw new HttpResponseException(new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent("No se ha encontrado el token de autenticidad"),
                    ReasonPhrase = "Error Token"
                });
            }
            else
            {
                var isValid = API.isValidToken(actionExecutedContext.HttpContext.Request.Headers.Authorization.ToString());
                if (!isValid)
                {
                    throw new HttpResponseException(new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
                    {
                        Content = new StringContent("El token usado no es valido"),
                        ReasonPhrase = "Error Token"
                    });
                }
            }
        }
    }
}
