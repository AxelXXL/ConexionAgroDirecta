namespace ScriptDebugges.AgroDirecta.Api.Services
{
    public class BaseServices
    {
        public readonly HttpResponseMessage _responseMessage;

        public static IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            return builder.Build();
        }
    }
}
