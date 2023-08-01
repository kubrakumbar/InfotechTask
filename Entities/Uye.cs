using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using InfotechTask.Enums;

namespace InfotechTask.Entities
{
    public class Uye : BaseEntity
    {
        [Required]
        [StringLength(30)]
        public string Mail { get; set; }

        [StringLength(20)]
        [Required]
        public string Sifre { get; set; }
        public Rol Rol { get; set; }

        //ilişkiler
        public ICollection<Musteri> Musteriler { get; set; }
        public ICollection<Uzman> Uzmanlar { get; set; }
    }
}
