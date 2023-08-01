using InfotechTask.Data;
using InfotechTask.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfotechTask.Controllers
{
    public class UyeOlController : Controller
    {
        private readonly Context context;
        public UyeOlController(Context _context)
        {
            context = _context;
        }
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Index(Uye u)
        {
            if (ModelState.IsValid)
            {
                var user = new Uye
                {
                    Mail = u.Mail,
                    Sifre = u.Sifre,
                    Rol = u.Rol
                };
                //var musteri = new Musteri
                //{

                //    UyeID = user.ID
                //};
                //context.Musteri.Add(musteri);
                context.Uye.Add(user);
                context.SaveChanges();
                if (user.Rol == Enums.Rol.Müşteri)
                {

                    return RedirectToAction("MusteriDetay", "Musteri",user.ID);
                }
                else
                {
                    return RedirectToAction("UzmanDetay", "Uzman");
                }

            }

            return View();
        }
    }
}
