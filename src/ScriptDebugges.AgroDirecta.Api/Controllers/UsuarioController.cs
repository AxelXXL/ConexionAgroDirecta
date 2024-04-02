using Microsoft.AspNetCore.Mvc;
using ScriptDebugges.AgroDirecta.Api.Services;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Usuario.Commands.CreateUser;
using ScriptDebugges.AgroDirecta.Application.Exceptions;
using ScriptDebugges.AgroDirecta.Application.Features;

namespace ScriptDebugges.AgroDirecta.Api.Controllers
{
    [Route("api/v1/Usuarios")]
    [ApiController]
    [TypeFilter(typeof(ExceptionManager))]
    public class UsuarioController : ControllerBase
    {
        public UsuarioController() { }

        [Auth]
        [HttpPost("Create")]
        public async Task<IActionResult> Create(
            [FromBody] CreateUserModelResponse newUser,
            [FromServices] ICreateUserQuery createUserQuery)
        {
            bool data = await createUserQuery.Execute(newUser);
            if (data)
            {
                return StatusCode(StatusCodes.Status201Created, ResponseApiService.Response(StatusCodes.Status201Created, "Usuario creado con exito."));
            }
            else
            {
                return StatusCode(StatusCodes.Status409Conflict, ResponseApiService.Response(StatusCodes.Status409Conflict, "Ocurrio un error inesperado."));
            }
        }
    }
}
