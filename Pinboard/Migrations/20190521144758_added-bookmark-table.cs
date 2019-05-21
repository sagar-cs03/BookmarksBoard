using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pinboard.Migrations
{
    public partial class addedbookmarktable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookmarks",
                columns: table => new
                {
                    URL = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Tags = table.Column<string>(nullable: true),
                    IsReadLater = table.Column<bool>(nullable: false),
                    IsStarred = table.Column<bool>(nullable: false),
                    IsTagged = table.Column<bool>(nullable: false),
                    DateAndTimeCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookmarks", x => x.URL);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookmarks");
        }
    }
}
