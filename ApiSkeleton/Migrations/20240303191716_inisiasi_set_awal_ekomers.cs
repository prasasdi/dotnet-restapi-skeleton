using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiSkeleton.Migrations
{
    /// <inheritdoc />
    public partial class inisiasi_set_awal_ekomers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pemesan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nama = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Telephone = table.Column<string>(type: "text", nullable: false),
                    Provinsi = table.Column<string>(type: "text", nullable: false),
                    Kota_Kab = table.Column<string>(type: "text", nullable: false),
                    Kodepost = table.Column<int>(type: "integer", nullable: false),
                    Alamat = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<TimeSpan>(type: "interval", nullable: false),
                    ModifiedAt = table.Column<TimeSpan>(type: "interval", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pemesan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produk",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nama = table.Column<string>(type: "text", nullable: false),
                    Harga = table.Column<int>(type: "integer", nullable: false),
                    Rating = table.Column<int>(type: "integer", nullable: false),
                    Deskripsi = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<TimeSpan>(type: "interval", nullable: false),
                    ModifiedAt = table.Column<TimeSpan>(type: "interval", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produk", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KomentarProduk",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IsiKomentar = table.Column<string>(type: "text", nullable: false),
                    IdProduk = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<TimeSpan>(type: "interval", nullable: false),
                    ModifiedAt = table.Column<TimeSpan>(type: "interval", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KomentarProduk", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KomentarProduk_Produk_IdProduk",
                        column: x => x.IdProduk,
                        principalTable: "Produk",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pesanan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Tipe = table.Column<char>(type: "character(1)", nullable: false),
                    Ukuran = table.Column<char>(type: "character(1)", nullable: false),
                    IdProduk = table.Column<Guid>(type: "uuid", nullable: false),
                    IdPemesan = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pesanan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pesanan_Pemesan_IdPemesan",
                        column: x => x.IdPemesan,
                        principalTable: "Pemesan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pesanan_Produk_IdProduk",
                        column: x => x.IdProduk,
                        principalTable: "Produk",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KomentarProduk_IdProduk",
                table: "KomentarProduk",
                column: "IdProduk");

            migrationBuilder.CreateIndex(
                name: "IX_Pesanan_IdPemesan",
                table: "Pesanan",
                column: "IdPemesan");

            migrationBuilder.CreateIndex(
                name: "IX_Pesanan_IdProduk",
                table: "Pesanan",
                column: "IdProduk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KomentarProduk");

            migrationBuilder.DropTable(
                name: "Pesanan");

            migrationBuilder.DropTable(
                name: "Pemesan");

            migrationBuilder.DropTable(
                name: "Produk");
        }
    }
}
