using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ScriptDebugges.AgroDirecta.Api.Services;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Commands.CreateCategoria;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Commands.DeleteCategoria;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Commands.UpdateCategoria;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Commands.CreateProductos;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Commands.DeleteProducto;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Commands.UpdateProducto;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Queries.GetAllProductosQuery;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Queries.GetProductosByIdQuery;
using ScriptDebugges.AgroDirecta.Application.Features;

namespace ScriptDebugges.AgroDirecta.Api.Controllers
{
    [Route("api/v1/productos")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        public ProductosController()
        {
            
        }
        [Auth]
        [HttpPost("create")]
        public async Task<IActionResult> Create(
           [FromBody] CreateProductosModel model,
           [FromServices] ICreateProductosCommand createProductosCommand)
        {
            var data = await createProductosCommand.Execute(model);
            return StatusCode(StatusCodes.Status201Created, ResponseApiService.Response(StatusCodes.Status201Created, data));
        }

        [Auth]
        [HttpPost("update")]
        public async Task<IActionResult> Update(
            [FromBody] UpdateProductoModel model,
            [FromServices] IUpdateProductoCommand updateProductoCommand)
        {
            var data = await updateProductoCommand.Execute(model);
            return StatusCode(StatusCodes.Status201Created, ResponseApiService.Response(StatusCodes.Status201Created, data, "Actualizado"));
        }

        [Auth]
        [HttpDelete("delete/{idProducto}")]
        public async Task<IActionResult> Delete(
            int idProducto,
            [FromServices] IDeleteProductoCommand deleteProductoCommand)
        {
            if (idProducto == 0)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));
            var data = await deleteProductoCommand.Execute(idProducto);

            if (!data)
                return StatusCode(StatusCodes.Status404NotFound, ResponseApiService.Response(StatusCodes.Status404NotFound, data));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }

        [Auth]
        [HttpGet("GetAll")]
        public async Task<IActionResult> Get(
            [FromServices] IGetAllProductosQuery getAllProductosQuery)
        {
           
            var data = await getAllProductosQuery.Execute();

            if (data.IsNullOrEmpty())
                return StatusCode(StatusCodes.Status404NotFound, ResponseApiService.Response(StatusCodes.Status404NotFound, data));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }

        [Auth]
        [HttpGet("GetById/{idProducto}")]
        public async Task<IActionResult> GetById(
            int idProducto,
           [FromServices] IGetProductosByIdQuery getProductosByIdQuery)
        {

            var data = await getProductosByIdQuery.Execute(idProducto);

            if (data.IsNullOrEmpty())
                return StatusCode(StatusCodes.Status404NotFound, ResponseApiService.Response(StatusCodes.Status404NotFound, data));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }
    }
}
