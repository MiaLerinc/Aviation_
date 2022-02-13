using Microsoft.EntityFrameworkCore.Migrations;

namespace AviationWebAPI.Migrations
{
    public partial class AddedCountryIdToAirportsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Airports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Airports_CountryId",
                table: "Airports",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Airports_Countries_CountryId",
                table: "Airports",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Airports_Countries_CountryId",
                table: "Airports");

            migrationBuilder.DropIndex(
                name: "IX_Airports_CountryId",
                table: "Airports");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Airports");
        }
    }
}
