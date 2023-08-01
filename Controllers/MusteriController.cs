using InfotechTask.Data;
using InfotechTask.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfotechTask.Controllers
{

    public class MusteriController : Controller
    {
        private readonly Context context;
        public MusteriController(Context _context)
        {
            context = _context;
        }


        [HttpGet]
        public IActionResult MusteriDetay()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MusteriDetay(Musteri m, int uyeid)
        {
            if (ModelState.IsValid)
            {
                var must = new Musteri
                {
                    Ad = m.Ad,
                    Soyad = m.Soyad,
                    Telefon = m.Telefon,
                    Il = m.Il,
                    Ilce = m.Ilce,
                    Mahalle = m.Mahalle,
                    PostaKodu = m.PostaKodu,
                    Adres = m.Adres 
             
                    
                }; 
                
                context.Musteri.Add(must);
                context.SaveChanges();


            return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}
