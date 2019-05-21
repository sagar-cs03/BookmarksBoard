using Microsoft.EntityFrameworkCore.Migrations;

namespace Pinboard.Migrations
{
    public partial class updateBookmark : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookmarks",
                table: "Bookmarks");

            migrationBuilder.AlterColumn<string>(
                name: "URL",
                table: "Bookmarks",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "BookmarkID",
                table: "Bookmarks",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookmarks",
                table: "Bookmarks",
                column: "BookmarkID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookmarks",
                table: "Bookmarks");

            migrationBuilder.DropColumn(
                name: "BookmarkID",
                table: "Bookmarks");

            migrationBuilder.AlterColumn<string>(
                name: "URL",
                table: "Bookmarks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookmarks",
                table: "Bookmarks",
                column: "URL");
        }
    }
}
