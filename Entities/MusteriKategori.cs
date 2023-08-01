using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfotechTask.Entities
{
    public class MusteriKategori
    {
        public int MusteriKategoriID { get; set; }
        public int MusteriID { get; set; }
        public int KategoriID { get; set; }

        public Musteri Musteri { get; set; }
        public Kategori Kategori { get; set; }
    }
}
