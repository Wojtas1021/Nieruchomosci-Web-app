using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nieruchomosci.Data.Migrations
{
    public partial class M4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Promocja",
                table: "Nieruchomosc",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Promocja",
                table: "Nieruchomosc");
        }
    }
}
