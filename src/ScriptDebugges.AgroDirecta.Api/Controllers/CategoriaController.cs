using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Commands.CreateCategoria;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Commands.DeleteCategoria;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Commands.UpdateCategoria;
using ScriptDebugges.AgroDirecta.Application.Exceptions;
using ScriptDebugges.AgroDirecta.Application.Features;

namespace ScriptDebugges.AgroDirecta.Api.Controllers
{
    [Route("api/v1/categoria")]
    [ApiController]
    [TypeFilter(typeof(ExceptionManager))]
    public class CategoriaController : ControllerBase
    {
        public CategoriaController()
        {
            
        }

        [HttpPost]
        public async Task<IActionResult> test()
        {
            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, "{}", "Ejecucion exitosa"));
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(
            [FromBody] CreateCategoriaModel model,
            [FromServices] ICreateCategoriaCommand createCategoriaCommand)
        {
            var data = await createCategoriaCommand.Execute(model);
            return StatusCode(StatusCodes.Status201Created, ResponseApiService.Response(StatusCodes.Status201Created, data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(
            [FromBody] UpdateCategoriaModel model,
            [FromServices] IUpdateCategoriaCommand updateCategoriaCommand)
        {
            var data = await updateCategoriaCommand.Execute(model);
            return StatusCode(StatusCodes.Status201Created, ResponseApiService.Response(StatusCodes.Status201Created, data,"Actualizado"));
        }

        [HttpDelete("delete/{idCategoria}")]
        public async Task<IActionResult> Delete(
            int idCategoria,
            [FromServices] IDeleteCategoriaCommand deleteCategoriaCommand)
        {
            if (idCategoria == 0)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));
            var data = await deleteCategoriaCommand.Execute(idCategoria);

            if (!data)
                return StatusCode(StatusCodes.Status404NotFound, ResponseApiService.Response(StatusCodes.Status404NotFound, data));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }
    }
}
