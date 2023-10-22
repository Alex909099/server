using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAuthorization22.Data.Migrations
{
    public partial class Achivementmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Achievement",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Achievement",
                table: "AspNetUsers");
        }
    }
}
