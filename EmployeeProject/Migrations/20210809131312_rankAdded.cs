using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeProject.Migrations
{
    public partial class rankAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RankId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Ranks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RankId = table.Column<int>(type: "int", nullable: true),
                    Level = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ranks", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_RankId",
                table: "Employees",
                column: "RankId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Ranks_RankId",
                table: "Employees",
                column: "RankId",
                principalTable: "Ranks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Ranks_RankId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Ranks");

            migrationBuilder.DropIndex(
                name: "IX_Employees_RankId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "RankId",
                table: "Employees");
        }
    }
}
