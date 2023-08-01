using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InfotechTask.Entities
{
    public class Yorum : BaseEntity
    {
        [StringLength(400)]
        public string? Aciklama { get; set; }
        public DateTime Tarih { get; set; } = DateTime.Now;

        //ilişkiler
        public int UzmanID { get; set; }
        public Uzman Uzman { get; set; }
        public int MusteriID { get; set; }
        public Musteri Musteri { get; set; }

    }
}
