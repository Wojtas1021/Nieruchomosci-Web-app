using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nieruchomosci.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aktualnosc",
                columns: table => new
                {
                    IdAktualnosci = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkTytul = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Tytul = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ikona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tresc = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Pozycja = table.Column<int>(type: "int", nullable: false),
                    Komentarz = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    DataUtworzenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PracownikDodajacy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataEdycji = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PracownikEdytujacy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataUsuniecia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PracownikUsuwajacy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CzyAktywny = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aktualnosc", x => x.IdAktualnosci);
                });

            migrationBuilder.CreateTable(
                name: "Dodatki",
                columns: table => new
                {
                    IdDodatku = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sypialnia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lazienka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parking = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WiFi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Basen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Silownia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Monitoring = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pralnia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataUtworzenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PracownikDodajacy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataEdycji = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PracownikEdytujacy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataUsuniecia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PracownikUsuwajacy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CzyAktywny = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dodatki", x => x.IdDodatku);
                });

            migrationBuilder.CreateTable(
                name: "Parametr",
                columns: table => new
                {
                    IdParametru = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kod = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Nazwa = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Wartosc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Komentarz = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Przycisk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrescPrzycisku = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataUtworzenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PracownikDodajacy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataEdycji = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PracownikEdytujacy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataUsuniecia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PracownikUsuwajacy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CzyAktywny = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametr", x => x.IdParametru);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    IdPostu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkPostu = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Tytul = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ikona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tresc = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Pozycja = table.Column<int>(type: "int", nullable: false),
                    Komentarz = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Przycisk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataUtworzenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataPublikacji = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataEdycji = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CzyPubliczny = table.Column<bool>(type: "bit", nullable: false),
                    CzyAktywny = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.IdPostu);
                });

            migrationBuilder.CreateTable(
                name: "Rekomendacja",
                columns: table => new
                {
                    IdRekomendacji = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkRekomendacji = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ikona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tresc = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Pozycja = table.Column<int>(type: "int", nullable: false),
                    Komentarz = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Przycisk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataUtworzenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataPublikacji = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ocena = table.Column<int>(type: "int", nullable: true),
                    DataEdycji = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CzyPubliczny = table.Column<bool>(type: "bit", nullable: false),
                    CzyAktywny = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rekomendacja", x => x.IdRekomendacji);
                });

            migrationBuilder.CreateTable(
                name: "RodzajNieruchomosci",
                columns: table => new
                {
                    IdRodzajuNieruchomosci = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nazwa = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    DataUtworzenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PracownikDodajacy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataEdycji = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PracownikEdytujacy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataUsuniecia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PracownikUsuwajacy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CzyAktywny = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RodzajNieruchomosci", x => x.IdRodzajuNieruchomosci);
                });

            migrationBuilder.CreateTable(
                name: "Strona",
                columns: table => new
                {
                    IdStrony = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkTytul = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Tytul = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ikona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tresc = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Pozycja = table.Column<int>(type: "int", nullable: false),
                    DataUtworzenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PracownikDodajacy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataEdycji = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PracownikEdytujacy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataUsuniecia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PracownikUsuwajacy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CzyAktywny = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Strona", x => x.IdStrony);
                });

            migrationBuilder.CreateTable(
                name: "Nieruchomosc",
                columns: table => new
                {
                    IdNieruchomosci = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tytul = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Forma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cena = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Powierzchnia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Osoby = table.Column<int>(type: "int", nullable: true),
                    Ocena = table.Column<int>(type: "int", nullable: true),
                    IdRodzajuNieruchomosci = table.Column<int>(type: "int", nullable: false),
                    RodzajNieruchomosciIdRodzajuNieruchomosci = table.Column<int>(type: "int", nullable: false),
                    IdDodatku = table.Column<int>(type: "int", nullable: false),
                    DodatkiIdDodatku = table.Column<int>(type: "int", nullable: false),
                    DataUtworzenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PracownikDodajacy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataEdycji = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PracownikEdytujacy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataUsuniecia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PracownikUsuwajacy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CzyAktywny = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nieruchomosc", x => x.IdNieruchomosci);
                    table.ForeignKey(
                        name: "FK_Nieruchomosc_Dodatki_DodatkiIdDodatku",
                        column: x => x.DodatkiIdDodatku,
                        principalTable: "Dodatki",
                        principalColumn: "IdDodatku",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Nieruchomosc_RodzajNieruchomosci_RodzajNieruchomosciIdRodzajuNieruchomosci",
                        column: x => x.RodzajNieruchomosciIdRodzajuNieruchomosci,
                        principalTable: "RodzajNieruchomosci",
                        principalColumn: "IdRodzajuNieruchomosci",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nieruchomosc_DodatkiIdDodatku",
                table: "Nieruchomosc",
                column: "DodatkiIdDodatku");

            migrationBuilder.CreateIndex(
                name: "IX_Nieruchomosc_RodzajNieruchomosciIdRodzajuNieruchomosci",
                table: "Nieruchomosc",
                column: "RodzajNieruchomosciIdRodzajuNieruchomosci");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aktualnosc");

            migrationBuilder.DropTable(
                name: "Nieruchomosc");

            migrationBuilder.DropTable(
                name: "Parametr");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Rekomendacja");

            migrationBuilder.DropTable(
                name: "Strona");

            migrationBuilder.DropTable(
                name: "Dodatki");

            migrationBuilder.DropTable(
                name: "RodzajNieruchomosci");
        }
    }
}
