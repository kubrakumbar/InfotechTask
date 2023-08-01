using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfotechTask.Controllers
{
    public class TeklifController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
