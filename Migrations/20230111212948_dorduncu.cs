using Microsoft.EntityFrameworkCore.Migrations;

namespace Sarih_Law.Migrations
{
    public partial class dorduncu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Yazar",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Yazar",
                table: "Blogs");
        }
    }
}
