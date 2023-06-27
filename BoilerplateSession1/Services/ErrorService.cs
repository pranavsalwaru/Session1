namespace BoilerplateSession1.Services
{
    public class ErrorService : IErrorService
    {
        readonly IConfiguration _configuration;
        public ErrorService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string getEnvironmentData()

        {
            return Environment.GetEnvironmentVariable("MyName");
        }
        public string getAppSettingData()
        {
            return _configuration.GetValue<string>("AppSettingData:Name");

        }
    }
}
