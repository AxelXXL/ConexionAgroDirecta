namespace ScriptDebugges.AgroDirecta.Domain.Model
{
    //CLASE PARA MODELO DE RESPUESTA PERSONALIZADO, ESTATUS, OPERACION EXITOSA O NO, MENSAJE Y DATOS EN CASO DE SER EXITOSO.
    public class BaseResponseModel
    {
        public int StatusCode { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
        public dynamic Data { get; set; }
    }
}
