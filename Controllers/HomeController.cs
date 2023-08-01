using InfotechTask.Data;
using InfotechTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace InfotechTask.Controllers
{
    public class HomeController : Controller
    {
    //    private readonly ILogger<HomeController> _logger;
        private readonly Context context;
        public HomeController(Context _context) // Constructor
        {
            context = _context;
        }
 

        public IActionResult Index()
        {
            var ktgr = context.Kategori.ToList();
    

            return View(ktgr);
        }
        public IActionResult KategoriList()
        {
            var ktgr = context.Kategori.ToList();


            return View(ktgr);
        }


    }
}
