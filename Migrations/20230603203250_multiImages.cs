using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class multiImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                schema: "AuthMVC",
                table: "Blogs");

            migrationBuilder.CreateTable(
                name: "ImagePaths",
                schema: "AuthMVC",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Path = table.Column<string>(type: "TEXT", nullable: true),
                    BlogModelId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagePaths", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImagePaths_Blogs_BlogModelId",
                        column: x => x.BlogModelId,
                        principalSchema: "AuthMVC",
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImagePaths_BlogModelId",
                schema: "AuthMVC",
                table: "ImagePaths",
                column: "BlogModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImagePaths",
                schema: "AuthMVC");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                schema: "AuthMVC",
                table: "Blogs",
                type: "TEXT",
                nullable: true);
        }
    }
}
