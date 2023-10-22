using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAuthorization22.Data.Migrations
{
    public partial class New_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AplicationID",
                table: "AspNetUsers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AplicationID",
                table: "AspNetUsers");
        }
    }
}
