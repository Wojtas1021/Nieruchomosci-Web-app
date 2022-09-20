using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nieruchomosci.Data.Migrations
{
    public partial class M3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nieruchomosc_Dodatki_DodatkiIdDodatku",
                table: "Nieruchomosc");

            migrationBuilder.DropTable(
                name: "Dodatki");

            migrationBuilder.DropIndex(
                name: "IX_Nieruchomosc_DodatkiIdDodatku",
                table: "Nieruchomosc");

            migrationBuilder.DropColumn(
                name: "DodatkiIdDodatku",
                table: "Nieruchomosc");

            migrationBuilder.DropColumn(
                name: "IdDodatku",
                table: "Nieruchomosc");

            migrationBuilder.AddColumn<string>(
                name: "Basen",
                table: "Nieruchomosc",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Klimatyzacja",
                table: "Nieruchomosc",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lazienka",
                table: "Nieruchomosc",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Monitoring",
                table: "Nieruchomosc",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Parking",
                table: "Nieruchomosc",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pralnia",
                table: "Nieruchomosc",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Silownia",
                table: "Nieruchomosc",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sypialnia",
                table: "Nieruchomosc",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WiFi",
                table: "Nieruchomosc",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Basen",
                table: "Nieruchomosc");

            migrationBuilder.DropColumn(
                name: "Klimatyzacja",
                table: "Nieruchomosc");

            migrationBuilder.DropColumn(
                name: "Lazienka",
                table: "Nieruchomosc");

            migrationBuilder.DropColumn(
                name: "Monitoring",
                table: "Nieruchomosc");

            migrationBuilder.DropColumn(
                name: "Parking",
                table: "Nieruchomosc");

            migrationBuilder.DropColumn(
                name: "Pralnia",
                table: "Nieruchomosc");

            migrationBuilder.DropColumn(
                name: "Silownia",
                table: "Nieruchomosc");

            migrationBuilder.DropColumn(
                name: "Sypialnia",
                table: "Nieruchomosc");

            migrationBuilder.DropColumn(
                name: "WiFi",
                table: "Nieruchomosc");

            migrationBuilder.AddColumn<int>(
                name: "DodatkiIdDodatku",
                table: "Nieruchomosc",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdDodatku",
                table: "Nieruchomosc",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Dodatki",
                columns: table => new
                {
                    IdDodatku = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Basen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CzyAktywny = table.Column<bool>(type: "bit", nullable: false),
                    DataEdycji = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataUsuniecia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataUtworzenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Lazienka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Monitoring = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parking = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PracownikDodajacy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PracownikEdytujacy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PracownikUsuwajacy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pralnia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Silownia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sypialnia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WiFi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dodatki", x => x.IdDodatku);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nieruchomosc_DodatkiIdDodatku",
                table: "Nieruchomosc",
                column: "DodatkiIdDodatku");

            migrationBuilder.AddForeignKey(
                name: "FK_Nieruchomosc_Dodatki_DodatkiIdDodatku",
                table: "Nieruchomosc",
                column: "DodatkiIdDodatku",
                principalTable: "Dodatki",
                principalColumn: "IdDodatku",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
