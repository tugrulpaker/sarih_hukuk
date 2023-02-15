using Microsoft.EntityFrameworkCore.Migrations;

namespace Sarih_Law.Migrations
{
    public partial class onuncu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlanID",
                table: "Blogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Alans",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlanAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alans", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_AlanID",
                table: "Blogs",
                column: "AlanID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Alans_AlanID",
                table: "Blogs",
                column: "AlanID",
                principalTable: "Alans",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Alans_AlanID",
                table: "Blogs");

            migrationBuilder.DropTable(
                name: "Alans");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_AlanID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "AlanID",
                table: "Blogs");
        }
    }
}
