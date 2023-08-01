using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfotechTask.Entities
{
    public class UzmanKategori  //ara tablo
    {
        public int UzmanKategoriID { get; set; }
        public int UzmanID { get; set; }
        public int KategoriID { get; set; }

        public Uzman Uzman { get; set; }
        public Kategori Kategori { get; set; }
    }
}
