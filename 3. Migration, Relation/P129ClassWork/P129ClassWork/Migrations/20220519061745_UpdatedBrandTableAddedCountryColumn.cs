using Microsoft.EntityFrameworkCore.Migrations;

namespace P129ClassWork.Migrations
{
    public partial class UpdatedBrandTableAddedCountryColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Brands",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Brands");
        }
    }
}
