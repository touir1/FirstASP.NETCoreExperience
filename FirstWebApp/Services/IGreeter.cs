using Microsoft.Extensions.Configuration;

namespace FirstWebApp.Services
{
    public interface IGreeter
    {
        string GetGreetingOfTheDay();
    }

    public class Greeter : IGreeter
    {
        private IConfiguration _configuration;

        public Greeter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetGreetingOfTheDay()
        {
            return _configuration["Greeting"];
        }
    }
}