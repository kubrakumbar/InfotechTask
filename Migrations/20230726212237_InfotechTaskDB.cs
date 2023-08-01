using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InfotechTask.Migrations
{
    public partial class InfotechTaskDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KategoriAciklama = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Uye",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mail = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Rol = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uye", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Musteri",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Il = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Ilce = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Mahalle = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PostaKodu = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UyeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteri", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Musteri_Uye_UyeID",
                        column: x => x.UyeID,
                        principalTable: "Uye",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Uzman",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    HizmetIl = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Ilce = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Mahalle = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Hakkında = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UyeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uzman", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Uzman_Uye_UyeID",
                        column: x => x.UyeID,
                        principalTable: "Uye",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MusteriKategoriler",
                columns: table => new
                {
                    MusteriKategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriID = table.Column<int>(type: "int", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriKategoriler", x => x.MusteriKategoriID);
                    table.ForeignKey(
                        name: "FK_MusteriKategoriler_Kategori_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategori",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MusteriKategoriler_Musteri_MusteriID",
                        column: x => x.MusteriID,
                        principalTable: "Musteri",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BitirilenIsler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UzmanID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BitirilenIsler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BitirilenIsler_Uzman_UzmanID",
                        column: x => x.UzmanID,
                        principalTable: "Uzman",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UzmanKategoriler",
                columns: table => new
                {
                    UzmanKategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UzmanID = table.Column<int>(type: "int", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UzmanKategoriler", x => x.UzmanKategoriID);
                    table.ForeignKey(
                        name: "FK_UzmanKategoriler_Kategori_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategori",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UzmanKategoriler_Uzman_UzmanID",
                        column: x => x.UzmanID,
                        principalTable: "Uzman",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yorum",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UzmanID = table.Column<int>(type: "int", nullable: false),
                    MusteriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorum", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Yorum_Musteri_MusteriID",
                        column: x => x.MusteriID,
                        principalTable: "Musteri",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Yorum_Uzman_UzmanID",
                        column: x => x.UzmanID,
                        principalTable: "Uzman",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Teklif",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TeklifTutar = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Durum = table.Column<int>(type: "int", nullable: true),
                    MusteriID = table.Column<int>(type: "int", nullable: false),
                    UzmanID = table.Column<int>(type: "int", nullable: false),
                    BitirilenIslerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teklif", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Teklif_BitirilenIsler_BitirilenIslerID",
                        column: x => x.BitirilenIslerID,
                        principalTable: "BitirilenIsler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teklif_Musteri_MusteriID",
                        column: x => x.MusteriID,
                        principalTable: "Musteri",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Teklif_Uzman_UzmanID",
                        column: x => x.UzmanID,
                        principalTable: "Uzman",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BitirilenIsler_UzmanID",
                table: "BitirilenIsler",
                column: "UzmanID");

            migrationBuilder.CreateIndex(
                name: "IX_Musteri_UyeID",
                table: "Musteri",
                column: "UyeID");

            migrationBuilder.CreateIndex(
                name: "IX_MusteriKategoriler_KategoriID",
                table: "MusteriKategoriler",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_MusteriKategoriler_MusteriID",
                table: "MusteriKategoriler",
                column: "MusteriID");

            migrationBuilder.CreateIndex(
                name: "IX_Teklif_BitirilenIslerID",
                table: "Teklif",
                column: "BitirilenIslerID");

            migrationBuilder.CreateIndex(
                name: "IX_Teklif_MusteriID",
                table: "Teklif",
                column: "MusteriID");

            migrationBuilder.CreateIndex(
                name: "IX_Teklif_UzmanID",
                table: "Teklif",
                column: "UzmanID");

            migrationBuilder.CreateIndex(
                name: "IX_Uzman_UyeID",
                table: "Uzman",
                column: "UyeID");

            migrationBuilder.CreateIndex(
                name: "IX_UzmanKategoriler_KategoriID",
                table: "UzmanKategoriler",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_UzmanKategoriler_UzmanID",
                table: "UzmanKategoriler",
                column: "UzmanID");

            migrationBuilder.CreateIndex(
                name: "IX_Yorum_MusteriID",
                table: "Yorum",
                column: "MusteriID");

            migrationBuilder.CreateIndex(
                name: "IX_Yorum_UzmanID",
                table: "Yorum",
                column: "UzmanID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MusteriKategoriler");

            migrationBuilder.DropTable(
                name: "Teklif");

            migrationBuilder.DropTable(
                name: "UzmanKategoriler");

            migrationBuilder.DropTable(
                name: "Yorum");

            migrationBuilder.DropTable(
                name: "BitirilenIsler");

            migrationBuilder.DropTable(
                name: "Kategori");

            migrationBuilder.DropTable(
                name: "Musteri");

            migrationBuilder.DropTable(
                name: "Uzman");

            migrationBuilder.DropTable(
                name: "Uye");
        }
    }
}
