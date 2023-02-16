using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acc.DAL.Migrations
{
    public partial class AddTeacherTableNullable3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCources_teachers_TeacherId",
                table: "StudentCources");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "StudentCources",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCources_teachers_TeacherId",
                table: "StudentCources",
                column: "TeacherId",
                principalTable: "teachers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCources_teachers_TeacherId",
                table: "StudentCources");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "StudentCources",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCources_teachers_TeacherId",
                table: "StudentCources",
                column: "TeacherId",
                principalTable: "teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
