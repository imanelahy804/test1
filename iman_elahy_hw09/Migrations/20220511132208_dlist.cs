using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iman_elahy_hw09.Migrations
{
    public partial class dlist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bookId",
                table: "members");

            migrationBuilder.AddColumn<int>(
                name: "Memberid",
                table: "books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Memberid",
                table: "books");

            migrationBuilder.AddColumn<int>(
                name: "bookId",
                table: "members",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
