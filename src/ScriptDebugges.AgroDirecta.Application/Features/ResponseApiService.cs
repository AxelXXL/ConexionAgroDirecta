using ScriptDebugges.AgroDirecta.Domain.Model;

namespace ScriptDebugges.AgroDirecta.Application.Features
{
    public static class ResponseApiService
    {
        //SERVICIO DE RESPUESTA PARA API, SE RECIBEN LOS DATOS DEL MODELO DE RESPUESTA PERSONALIZADO
        public static BaseResponseModel Response(int statusCode, object Data = null, string message = null)
        {
            bool success = false;

            if(statusCode >= 200 && statusCode <300)
                success = true;

            var result = new BaseResponseModel
            {
                StatusCode = statusCode,
                Success = success,
                Data = Data,
                Message = message
            };
            return result;
        }
    }
}
