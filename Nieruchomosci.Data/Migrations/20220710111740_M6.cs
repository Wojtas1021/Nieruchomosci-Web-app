using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nieruchomosci.Data.Migrations
{
    public partial class M6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NazwaWidoku",
                table: "Strona",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NazwaWidoku",
                table: "Strona");
        }
    }
}
