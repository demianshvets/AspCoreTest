using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspCorePractice.Controllers
{
    public class JumpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}