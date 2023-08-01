using InfotechTask.Data;
using InfotechTask.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InfotechTask.Controllers
{

    public class GirisYapController : Controller
    {
        private readonly Context context;
        public GirisYapController(Context _context)
        {
            context = _context;
        }


        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Uye u)
        {

            var user = context.Uye.FirstOrDefault(x => x.Mail == u.Mail && x.Sifre == u.Sifre);
            if (user != null)
            {
               
                    return RedirectToAction("Index", "Home");
                
            }
            else
            {
                return RedirectToAction("Index", "GirisYap");
            }

        }
    }
}
