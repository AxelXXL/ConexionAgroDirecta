namespace ScriptDebugges.AgroDirecta.Api.Models
{
    public class TokenModel
    {
    }

    public class TokenRequestModel
    {
        public Guid AppID { get; set; }
        public DateTime RecordDate { get; set; }
    }

    public class TokenResponseModel
    {
        public string Token { get; set; }
    }
}
