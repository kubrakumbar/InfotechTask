using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InfotechTask.Entities
{
    public class Kategori : BaseEntity
    {
        [StringLength(50)]
        public string? KategoriAdi { get; set; }
    
        [StringLength(100)]
        public string? KategoriAciklama { get; set; }
        [StringLength(100)]
        public string? Resim { get; set; }

        //ilişkiler
        public ICollection<MusteriKategori> MusteriKategoriler { get; set; }

        public ICollection<UzmanKategori> UzmanKategoriler { get; set; }

    }
}
