using Microsoft.EntityFrameworkCore.Migrations;

namespace AviationWebAPI.Migrations
{
    public partial class AddIsArchivedColumnToAirportsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "Airports",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "Airports");
        }
    }
}
