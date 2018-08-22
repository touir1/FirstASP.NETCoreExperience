using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    [Route("[controller]")]
    public class AboutController
    {
        [Route("")]
        public string Phone()
        {
            return "11+222+333+4444";
        }

        [Route("[action]")]
        public string Address()
        {
            return "Tunisia";
        }
    }
}
