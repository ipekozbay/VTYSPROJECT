using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Market_otomasyon.Migrations
{
    public partial class dbinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Borcs",
                columns: table => new
                {
                    BorcID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriID = table.Column<int>(nullable: false),
                    MusteriAd = table.Column<string>(nullable: true),
                    MusteriSoyad = table.Column<string>(nullable: true),
                    Tutar = table.Column<double>(nullable: false),
                    SatinAlmaTarihi = table.Column<DateTime>(nullable: false),
                    MusteriOdeme = table.Column<double>(nullable: false),
                    KalanBorc = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borcs", x => x.BorcID);
                });

            migrationBuilder.CreateTable(
                name: "Musteris",
                columns: table => new
                {
                    MusteriID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriAd = table.Column<string>(nullable: true),
                    MusteriSoyad = table.Column<string>(nullable: true),
                    TelefonNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteris", x => x.MusteriID);
                });

            migrationBuilder.CreateTable(
                name: "PesinSatis",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaturaID = table.Column<int>(nullable: false),
                    Tutar = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PesinSatis", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Satıcıs",
                columns: table => new
                {
                    SaticiID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaticiAd = table.Column<string>(nullable: true),
                    SaticiSoyad = table.Column<string>(nullable: true),
                    KullaniciAdi = table.Column<string>(nullable: true),
                    Sifre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Satıcıs", x => x.SaticiID);
                });

            migrationBuilder.CreateTable(
                name: "Satis",
                columns: table => new
                {
                    SatisID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaturaID = table.Column<int>(nullable: false),
                    MusteriID = table.Column<int>(nullable: false),
                    UrunID = table.Column<int>(nullable: false),
                    SatisTipi = table.Column<string>(nullable: true),
                    Miktar = table.Column<int>(nullable: false),
                    Tutar = table.Column<double>(nullable: false),
                    SatinAlmaTarihi = table.Column<DateTime>(nullable: false),
                    Barkod = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Satis", x => x.SatisID);
                });

            migrationBuilder.CreateTable(
                name: "Stoks",
                columns: table => new
                {
                    StokID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunKodu = table.Column<int>(nullable: false),
                    Barkod = table.Column<int>(nullable: false),
                    Cesit = table.Column<string>(nullable: true),
                    StokMiktari = table.Column<int>(nullable: false),
                    UrunAdi = table.Column<string>(nullable: true),
                    BirimGirdiFiyat = table.Column<double>(nullable: false),
                    SatisFiyati = table.Column<double>(nullable: false),
                    IrsaliyeNo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stoks", x => x.StokID);
                });

            migrationBuilder.CreateTable(
                name: "TedarikciBorcs",
                columns: table => new
                {
                    TedarikciBorcID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TedarikciID = table.Column<int>(nullable: false),
                    Tedarikcisim = table.Column<string>(nullable: true),
                    IrsaliyeNo = table.Column<int>(nullable: false),
                    TedarikBorc = table.Column<double>(nullable: false),
                    TedarikOdeme = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TedarikciBorcs", x => x.TedarikciBorcID);
                });

            migrationBuilder.CreateTable(
                name: "Tedarikcis",
                columns: table => new
                {
                    TedarikciID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tedarikcisim = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tedarikcis", x => x.TedarikciID);
                });

            migrationBuilder.CreateTable(
                name: "VeresiyeSatis",
                columns: table => new
                {
                    VeresiyeSatisID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriID = table.Column<int>(nullable: false),
                    MusteriAd = table.Column<string>(nullable: true),
                    MusteriSoyad = table.Column<string>(nullable: true),
                    SatinAlmaTarihi = table.Column<DateTime>(nullable: false),
                    Tutar = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeresiyeSatis", x => x.VeresiyeSatisID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Borcs");

            migrationBuilder.DropTable(
                name: "Musteris");

            migrationBuilder.DropTable(
                name: "PesinSatis");

            migrationBuilder.DropTable(
                name: "Satıcıs");

            migrationBuilder.DropTable(
                name: "Satis");

            migrationBuilder.DropTable(
                name: "Stoks");

            migrationBuilder.DropTable(
                name: "TedarikciBorcs");

            migrationBuilder.DropTable(
                name: "Tedarikcis");

            migrationBuilder.DropTable(
                name: "VeresiyeSatis");
        }
    }
}
