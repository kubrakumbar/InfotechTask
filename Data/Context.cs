using InfotechTask.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfotechTask.Data
{
    public class Context : IdentityDbContext<IdentityUser>  
    {
        public Context(DbContextOptions options) : base(options)
        {

        }

        public DbSet<BitirilenIsler> BitirilenIsler { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Musteri> Musteri { get; set; }
        public DbSet<Teklif> Teklif { get; set; }
        public DbSet<Uye> Uye { get; set; }
        public DbSet<Uzman> Uzman { get; set; }
        public DbSet<Yorum> Yorum { get; set; }

        //ara tablolar
        public DbSet<MusteriKategori> MusteriKategoriler { get; set; }
        public DbSet<UzmanKategori> UzmanKategoriler { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Teklif>()
                .Property(t => t.TeklifTutar)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Yorum>()
        .HasOne(y => y.Uzman)
        .WithMany(u => u.Yorumlar)
        .HasForeignKey(y => y.UzmanID)
        .OnDelete(DeleteBehavior.NoAction);  

            modelBuilder.Entity<Yorum>()
                .HasOne(y => y.Musteri)
                .WithMany(m => m.Yorumlar)
                .HasForeignKey(y => y.MusteriID)
                .OnDelete(DeleteBehavior.NoAction);  
            modelBuilder.Entity<Teklif>()
    .HasOne(t => t.Musteri)
    .WithMany(m => m.Teklifler)
    .HasForeignKey(t => t.MusteriID)
    .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Teklif>()
                .HasOne(t => t.Uzman)
                .WithMany(u => u.Teklifler)
                .HasForeignKey(t => t.UzmanID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<BitirilenIsler>()
                .HasMany(b => b.Teklifler)
                .WithOne(t => t.BitirilenIsler)
                .HasForeignKey(t => t.BitirilenIslerID)
                .OnDelete(DeleteBehavior.Cascade);
            base.OnModelCreating(modelBuilder);
        }
    }
}
