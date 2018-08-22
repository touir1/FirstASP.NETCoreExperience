using Microsoft.Extensions.Configuration;

namespace FirstWebApp.Services
{
    public interface IGreeter
    {
        string getGreetingOfTheDay();
    }

    public class Greeter : IGreeter
    {
        private IConfiguration _configuration;

        public Greeter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string getGreetingOfTheDay()
        {
            return "Greeting from Greeter : IGreeter -> getGreetingOfTheDay()\n" +
                "using appsettings Greeting value: "+_configuration["Greeting"];
        }
    }
}