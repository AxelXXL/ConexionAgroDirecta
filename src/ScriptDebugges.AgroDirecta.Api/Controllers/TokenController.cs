using Microsoft.AspNetCore.Mvc;
using ScriptDebugges.AgroDirecta.Api.Models;
using ScriptDebugges.AgroDirecta.Api.Services;
using ScriptDebugges.AgroDirecta.Application.Exceptions;

namespace ScriptDebugges.AgroDirecta.Api.Controllers
{
    [Route("api/v1/Token")]
    [ApiController]
    [TypeFilter(typeof(ExceptionManager))]
    public class TokenController : ControllerBase
    {
        public TokenController() { }

        [HttpGet("GetToken")]
        public TokenResponseModel GenerateNewToken(Guid ID_App)
        {
            return new TokenResponseModel() { Token = Security.GenerateNewToken(ID_App) };
        }
    }
}
