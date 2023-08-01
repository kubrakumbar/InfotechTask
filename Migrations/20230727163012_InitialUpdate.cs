using Microsoft.EntityFrameworkCore.Migrations;

namespace InfotechTask.Migrations
{
    public partial class InitialUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Uzman_Uye_UyeID",
                table: "Uzman");

            migrationBuilder.AlterColumn<int>(
                name: "UyeID",
                table: "Uzman",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Resim",
                table: "Kategori",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Uzman_Uye_UyeID",
                table: "Uzman",
                column: "UyeID",
                principalTable: "Uye",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Uzman_Uye_UyeID",
                table: "Uzman");

            migrationBuilder.DropColumn(
                name: "Resim",
                table: "Kategori");

            migrationBuilder.AlterColumn<int>(
                name: "UyeID",
                table: "Uzman",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Uzman_Uye_UyeID",
                table: "Uzman",
                column: "UyeID",
                principalTable: "Uye",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
