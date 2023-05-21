using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class react : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "rater",
                schema: "AuthMVC",
                table: "Reactions",
                newName: "reactor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "reactor",
                schema: "AuthMVC",
                table: "Reactions",
                newName: "rater");
        }
    }
}
