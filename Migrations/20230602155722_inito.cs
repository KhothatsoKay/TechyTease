using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class inito : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "number",
                schema: "AuthMVC",
                table: "Reactions",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "song",
                schema: "AuthMVC",
                table: "Reactions",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "number",
                schema: "AuthMVC",
                table: "Reactions");

            migrationBuilder.DropColumn(
                name: "song",
                schema: "AuthMVC",
                table: "Reactions");
        }
    }
}
