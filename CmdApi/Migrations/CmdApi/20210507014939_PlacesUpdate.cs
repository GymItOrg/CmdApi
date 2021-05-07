using Microsoft.EntityFrameworkCore.Migrations;

namespace CmdApi.Migrations.CmdApi
{
    public partial class PlacesUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CatersTo",
                table: "Places",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rate",
                table: "Places",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CatersTo",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Places");
        }
    }
}
