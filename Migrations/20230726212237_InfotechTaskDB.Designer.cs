﻿// <auto-generated />
using System;
using InfotechTask.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InfotechTask.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230726212237_InfotechTaskDB")]
    partial class InfotechTaskDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InfotechTask.Entities.BitirilenIsler", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<int>("UzmanID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UzmanID");

                    b.ToTable("BitirilenIsler");
                });

            modelBuilder.Entity("InfotechTask.Entities.Kategori", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KategoriAciklama")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("KategoriAdi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Kategori");
                });

            modelBuilder.Entity("InfotechTask.Entities.Musteri", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Adres")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Il")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Ilce")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Mahalle")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PostaKodu")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Soyad")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Telefon")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int>("UyeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UyeID");

                    b.ToTable("Musteri");
                });

            modelBuilder.Entity("InfotechTask.Entities.MusteriKategori", b =>
                {
                    b.Property<int>("MusteriKategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<int>("MusteriID")
                        .HasColumnType("int");

                    b.HasKey("MusteriKategoriID");

                    b.HasIndex("KategoriID");

                    b.HasIndex("MusteriID");

                    b.ToTable("MusteriKategoriler");
                });

            modelBuilder.Entity("InfotechTask.Entities.Teklif", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<int>("BitirilenIslerID")
                        .HasColumnType("int");

                    b.Property<int?>("Durum")
                        .HasColumnType("int");

                    b.Property<int>("MusteriID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("TeklifTutar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UzmanID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BitirilenIslerID");

                    b.HasIndex("MusteriID");

                    b.HasIndex("UzmanID");

                    b.ToTable("Teklif");
                });

            modelBuilder.Entity("InfotechTask.Entities.Uye", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Rol")
                        .HasColumnType("int");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.ToTable("Uye");
                });

            modelBuilder.Entity("InfotechTask.Entities.Uzman", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Hakkında")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("HizmetIl")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Ilce")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Mahalle")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Phone")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Soyad")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("UyeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UyeID");

                    b.ToTable("Uzman");
                });

            modelBuilder.Entity("InfotechTask.Entities.UzmanKategori", b =>
                {
                    b.Property<int>("UzmanKategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<int>("UzmanID")
                        .HasColumnType("int");

                    b.HasKey("UzmanKategoriID");

                    b.HasIndex("KategoriID");

                    b.HasIndex("UzmanID");

                    b.ToTable("UzmanKategoriler");
                });

            modelBuilder.Entity("InfotechTask.Entities.Yorum", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<int>("MusteriID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<int>("UzmanID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MusteriID");

                    b.HasIndex("UzmanID");

                    b.ToTable("Yorum");
                });

            modelBuilder.Entity("InfotechTask.Entities.BitirilenIsler", b =>
                {
                    b.HasOne("InfotechTask.Entities.Uzman", "Uzman")
                        .WithMany("BitirilenIsler")
                        .HasForeignKey("UzmanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Uzman");
                });

            modelBuilder.Entity("InfotechTask.Entities.Musteri", b =>
                {
                    b.HasOne("InfotechTask.Entities.Uye", "Uye")
                        .WithMany("Musteriler")
                        .HasForeignKey("UyeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Uye");
                });

            modelBuilder.Entity("InfotechTask.Entities.MusteriKategori", b =>
                {
                    b.HasOne("InfotechTask.Entities.Kategori", "Kategori")
                        .WithMany("MusteriKategoriler")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InfotechTask.Entities.Musteri", "Musteri")
                        .WithMany("MusteriKategoriler")
                        .HasForeignKey("MusteriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");

                    b.Navigation("Musteri");
                });

            modelBuilder.Entity("InfotechTask.Entities.Teklif", b =>
                {
                    b.HasOne("InfotechTask.Entities.BitirilenIsler", "BitirilenIsler")
                        .WithMany("Teklifler")
                        .HasForeignKey("BitirilenIslerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InfotechTask.Entities.Musteri", "Musteri")
                        .WithMany("Teklifler")
                        .HasForeignKey("MusteriID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("InfotechTask.Entities.Uzman", "Uzman")
                        .WithMany("Teklifler")
                        .HasForeignKey("UzmanID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("BitirilenIsler");

                    b.Navigation("Musteri");

                    b.Navigation("Uzman");
                });

            modelBuilder.Entity("InfotechTask.Entities.Uzman", b =>
                {
                    b.HasOne("InfotechTask.Entities.Uye", "Uye")
                        .WithMany("Uzmanlar")
                        .HasForeignKey("UyeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Uye");
                });

            modelBuilder.Entity("InfotechTask.Entities.UzmanKategori", b =>
                {
                    b.HasOne("InfotechTask.Entities.Kategori", "Kategori")
                        .WithMany("UzmanKategoriler")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InfotechTask.Entities.Uzman", "Uzman")
                        .WithMany("UzmanKategoriler")
                        .HasForeignKey("UzmanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");

                    b.Navigation("Uzman");
                });

            modelBuilder.Entity("InfotechTask.Entities.Yorum", b =>
                {
                    b.HasOne("InfotechTask.Entities.Musteri", "Musteri")
                        .WithMany("Yorumlar")
                        .HasForeignKey("MusteriID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("InfotechTask.Entities.Uzman", "Uzman")
                        .WithMany("Yorumlar")
                        .HasForeignKey("UzmanID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Musteri");

                    b.Navigation("Uzman");
                });

            modelBuilder.Entity("InfotechTask.Entities.BitirilenIsler", b =>
                {
                    b.Navigation("Teklifler");
                });

            modelBuilder.Entity("InfotechTask.Entities.Kategori", b =>
                {
                    b.Navigation("MusteriKategoriler");

                    b.Navigation("UzmanKategoriler");
                });

            modelBuilder.Entity("InfotechTask.Entities.Musteri", b =>
                {
                    b.Navigation("MusteriKategoriler");

                    b.Navigation("Teklifler");

                    b.Navigation("Yorumlar");
                });

            modelBuilder.Entity("InfotechTask.Entities.Uye", b =>
                {
                    b.Navigation("Musteriler");

                    b.Navigation("Uzmanlar");
                });

            modelBuilder.Entity("InfotechTask.Entities.Uzman", b =>
                {
                    b.Navigation("BitirilenIsler");

                    b.Navigation("Teklifler");

                    b.Navigation("UzmanKategoriler");

                    b.Navigation("Yorumlar");
                });
#pragma warning restore 612, 618
        }
    }
}