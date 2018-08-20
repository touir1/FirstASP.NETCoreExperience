using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public String Index()
        {
            return "hello world, this is the home view";
        }
    }
}