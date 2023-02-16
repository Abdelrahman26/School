using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acc.DAL.Migrations
{
    public partial class CreateTeacherTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCources_teachers_TeacherId",
                table: "StudentCources");

            migrationBuilder.DropIndex(
                name: "IX_StudentCources_TeacherId",
                table: "StudentCources");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "StudentCources");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "StudentCources",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentCources_TeacherId",
                table: "StudentCources",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCources_teachers_TeacherId",
                table: "StudentCources",
                column: "TeacherId",
                principalTable: "teachers",
                principalColumn: "Id");
        }
    }
}
