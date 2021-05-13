using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspCorePractice.Controllers
{
    public class TestBranchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}