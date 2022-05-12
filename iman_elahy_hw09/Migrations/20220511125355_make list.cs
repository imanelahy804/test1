using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iman_elahy_hw09.Migrations
{
    public partial class makelist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_libraries_libraryNameId",
                table: "books");

            migrationBuilder.DropForeignKey(
                name: "FK_books_members_MemberID",
                table: "books");

            migrationBuilder.DropIndex(
                name: "IX_books_MemberID",
                table: "books");

            migrationBuilder.DropColumn(
                name: "MemberID",
                table: "books");

            migrationBuilder.RenameColumn(
                name: "libraryNameId",
                table: "books",
                newName: "libraryId");

            migrationBuilder.RenameIndex(
                name: "IX_books_libraryNameId",
                table: "books",
                newName: "IX_books_libraryId");

            migrationBuilder.AddColumn<int>(
                name: "bookId",
                table: "members",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "libraryId",
                table: "members",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_books_libraries_libraryId",
                table: "books",
                column: "libraryId",
                principalTable: "libraries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_libraries_libraryId",
                table: "books");

            migrationBuilder.DropColumn(
                name: "bookId",
                table: "members");

            migrationBuilder.DropColumn(
                name: "libraryId",
                table: "members");

            migrationBuilder.RenameColumn(
                name: "libraryId",
                table: "books",
                newName: "libraryNameId");

            migrationBuilder.RenameIndex(
                name: "IX_books_libraryId",
                table: "books",
                newName: "IX_books_libraryNameId");

            migrationBuilder.AddColumn<int>(
                name: "MemberID",
                table: "books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_books_MemberID",
                table: "books",
                column: "MemberID");

            migrationBuilder.AddForeignKey(
                name: "FK_books_libraries_libraryNameId",
                table: "books",
                column: "libraryNameId",
                principalTable: "libraries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_books_members_MemberID",
                table: "books",
                column: "MemberID",
                principalTable: "members",
                principalColumn: "ID");
        }
    }
}
