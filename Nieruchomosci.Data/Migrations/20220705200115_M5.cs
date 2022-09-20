using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nieruchomosci.Data.Migrations
{
    public partial class M5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ElementKoszyka",
                columns: table => new
                {
                    IdElementuKoszyka = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSesjiKoszyka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdNieruchomosci = table.Column<int>(type: "int", nullable: false),
                    NieruchomoscIdNieruchomosci = table.Column<int>(type: "int", nullable: false),
                    Ilosc = table.Column<int>(type: "int", nullable: false),
                    DataUtworzenia = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementKoszyka", x => x.IdElementuKoszyka);
                    table.ForeignKey(
                        name: "FK_ElementKoszyka_Nieruchomosc_NieruchomoscIdNieruchomosci",
                        column: x => x.NieruchomoscIdNieruchomosci,
                        principalTable: "Nieruchomosc",
                        principalColumn: "IdNieruchomosci",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElementKoszyka_NieruchomoscIdNieruchomosci",
                table: "ElementKoszyka",
                column: "NieruchomoscIdNieruchomosci");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElementKoszyka");
        }
    }
}
