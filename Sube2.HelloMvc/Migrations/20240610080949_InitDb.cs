﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sube2.HelloMvc.Migrations
{
    /// <inheritdoc />
    public partial class InitDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblDersler",
                columns: table => new
                {
                    Dersid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersAd = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    DersKodu = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    Kredi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDersler", x => x.Dersid);
                });

            migrationBuilder.CreateTable(
                name: "tblOgrenciler",
                columns: table => new
                {
                    Ogrenciid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Soyad = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    Numara = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOgrenciler", x => x.Ogrenciid);
                });

            migrationBuilder.CreateTable(
                name: "tblOgrenciDersler",
                columns: table => new
                {
                    Ogrenciid = table.Column<int>(type: "int", nullable: false),
                    Dersid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOgrenciDersler", x => new { x.Ogrenciid, x.Dersid });
                    table.ForeignKey(
                        name: "FK_tblOgrenciDersler_tblDersler_Dersid",
                        column: x => x.Dersid,
                        principalTable: "tblDersler",
                        principalColumn: "Dersid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblOgrenciDersler_tblOgrenciler_Ogrenciid",
                        column: x => x.Ogrenciid,
                        principalTable: "tblOgrenciler",
                        principalColumn: "Ogrenciid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblOgrenciDersler_Dersid",
                table: "tblOgrenciDersler",
                column: "Dersid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblOgrenciDersler");

            migrationBuilder.DropTable(
                name: "tblDersler");

            migrationBuilder.DropTable(
                name: "tblOgrenciler");
        }
    }
}
