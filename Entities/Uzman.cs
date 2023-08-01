using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InfotechTask.Entities
{
    public class Uzman : BaseEntity
    {
        [StringLength(20)]
        public string? Ad { get; set; }

        [StringLength(20)]
        public string? Soyad { get; set; }

        [StringLength(11)]
        public string? Phone { get; set; }

        [StringLength(20)]
        public string? HizmetIl { get; set; }

        [StringLength(20)]
        public string? Ilce { get; set; }

        [StringLength(30)]
        public string? Mahalle { get; set; }

        [StringLength(100)]
        public string? Hakkında { get; set; }

        //ilişkiler
        public ICollection<Yorum> Yorumlar { get; set; }
        public ICollection<BitirilenIsler> BitirilenIsler { get; set; }
        public ICollection<Teklif> Teklifler { get; set; }
        public ICollection<UzmanKategori> UzmanKategoriler { get; set; }
        public int? UyeID { get; set; }
        public Uye Uye { get; set; }

    }
}
