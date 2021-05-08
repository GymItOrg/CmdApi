using Microsoft.EntityFrameworkCore.Migrations;

namespace CmdApi.Migrations.CmdApi
{
    public partial class PlacesUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "hasFreeweights",
                table: "Places",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "hasMachines",
                table: "Places",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "numTreadmills",
                table: "Places",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "hasFreeweights",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "hasMachines",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "numTreadmills",
                table: "Places");
        }
    }
}
