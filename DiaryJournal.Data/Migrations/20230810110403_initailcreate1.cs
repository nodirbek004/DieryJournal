using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiaryJournal.Data.Migrations
{
    public partial class initailcreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Journal",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Journal");
        }
    }
}
