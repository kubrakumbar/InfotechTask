using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InfotechTask.Entities
{
    public class Musteri : BaseEntity
    {
        [StringLength(20)]
        public string? Ad { get; set; }
        [StringLength(20)]
        public string? Soyad { get; set; }
        [StringLength(11)]
        public string? Telefon { get; set; }
        [StringLength(20)]
        public string? Il { get; set; }
        [StringLength(20)]
        public string? Ilce { get; set; }
        [StringLength(30)]
        public string? Mahalle { get; set; }
        [StringLength(10)]
        public string? PostaKodu { get; set; }
        [StringLength(100)]
        public string? Adres { get; set; }

        //ilişkiler
        public ICollection<Yorum> Yorumlar { get; set; }
        public ICollection<Teklif> Teklifler { get; set; }
        public ICollection<MusteriKategori> MusteriKategoriler { get; set; }
        public int? UyeID { get; set; }
        public Uye Uye { get; set; }
    }
}
