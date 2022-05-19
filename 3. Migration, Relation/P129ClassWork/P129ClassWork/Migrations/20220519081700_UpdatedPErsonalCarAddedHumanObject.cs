using Microsoft.EntityFrameworkCore.Migrations;

namespace P129ClassWork.Migrations
{
    public partial class UpdatedPErsonalCarAddedHumanObject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Humen_PersonalCardId",
                table: "Humen");

            migrationBuilder.CreateIndex(
                name: "IX_Humen_PersonalCardId",
                table: "Humen",
                column: "PersonalCardId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Humen_PersonalCardId",
                table: "Humen");

            migrationBuilder.CreateIndex(
                name: "IX_Humen_PersonalCardId",
                table: "Humen",
                column: "PersonalCardId");
        }
    }
}
