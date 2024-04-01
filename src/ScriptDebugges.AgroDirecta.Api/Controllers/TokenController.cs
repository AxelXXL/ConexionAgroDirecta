using ScriptDebugges.AgroDirecta.Api.Models;
using ScriptDebugges.AgroDirecta.Api.Services;
using System.Web.Http;

namespace ScriptDebugges.AgroDirecta.Api.Controllers
{
    public class TokenController : ApiController
    {
        [Route("api/GetToken")]
        [HttpGet]
        public TokenResponseModel GenerateNewToken(Guid ID_App)
        {
            return new TokenResponseModel() { Token = Security.GenerateNewToken(ID_App) };
        }
    }
}
