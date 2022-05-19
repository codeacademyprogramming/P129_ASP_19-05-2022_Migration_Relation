using Microsoft.EntityFrameworkCore.Migrations;

namespace P129ClassWork.Migrations
{
    public partial class AddedTabelsQrupAndTelebe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Qrups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qrups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Telebes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    QrupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telebes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Telebes_Qrups_QrupId",
                        column: x => x.QrupId,
                        principalTable: "Qrups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Telebes_QrupId",
                table: "Telebes",
                column: "QrupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Telebes");

            migrationBuilder.DropTable(
                name: "Qrups");
        }
    }
}
