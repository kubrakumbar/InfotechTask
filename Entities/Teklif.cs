using InfotechTask.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfotechTask.Entities
{
    public class Teklif :BaseEntity
    {
        [StringLength(400)]
        public string? Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? TeklifTutar { get; set; }
        public Durum? Durum { get; set; }

        //ilişkiler
        public int MusteriID { get; set; }
        public Musteri Musteri { get; set; }

        public int UzmanID { get; set; }
        public Uzman Uzman { get; set; }

        public int BitirilenIslerID { get; set; }
        public BitirilenIsler BitirilenIsler { get; set; }
    }
}
