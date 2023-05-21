using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class noti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogId",
                schema: "AuthMVC",
                table: "Notifications",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NotificationType",
                schema: "AuthMVC",
                table: "Notifications",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlogId",
                schema: "AuthMVC",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "NotificationType",
                schema: "AuthMVC",
                table: "Notifications");
        }
    }
}
