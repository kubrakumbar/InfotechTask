using InfotechTask.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfotechTask.Controllers
{
    public class KategoriController : Controller
    {
        private readonly Context context;
        public KategoriController(Context _context) 
        {
            context = _context;
        }
        public IActionResult Index(int id)
        {
            var ktg = context.Kategori.FirstOrDefault(x => x.ID == id);
            if (ktg == null)
            {
                return NotFound();
            }
            return View(ktg);
        }
    }
}
