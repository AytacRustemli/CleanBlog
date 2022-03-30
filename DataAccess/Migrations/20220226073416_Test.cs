using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogId",
                table: "BlogLanguages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LangCode",
                table: "BlogLanguages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_BlogLanguages_BlogId",
                table: "BlogLanguages",
                column: "BlogId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogLanguages_Blogs_BlogId",
                table: "BlogLanguages",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogLanguages_Blogs_BlogId",
                table: "BlogLanguages");

            migrationBuilder.DropIndex(
                name: "IX_BlogLanguages_BlogId",
                table: "BlogLanguages");

            migrationBuilder.DropColumn(
                name: "BlogId",
                table: "BlogLanguages");

            migrationBuilder.DropColumn(
                name: "LangCode",
                table: "BlogLanguages");
        }
    }
}
