using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NewTestApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "From Home Index";
        }
    }
}
