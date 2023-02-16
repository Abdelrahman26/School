using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acc.DAL.Migrations
{
    public partial class AddTeacherTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "StudentCources",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teachers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentCources_TeacherId",
                table: "StudentCources",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCources_teachers_TeacherId",
                table: "StudentCources",
                column: "TeacherId",
                principalTable: "teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCources_teachers_TeacherId",
                table: "StudentCources");

            migrationBuilder.DropTable(
                name: "teachers");

            migrationBuilder.DropIndex(
                name: "IX_StudentCources_TeacherId",
                table: "StudentCources");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "StudentCources");
        }
    }
}
