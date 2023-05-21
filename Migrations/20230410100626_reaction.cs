using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class reaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ratings",
                schema: "AuthMVC");

            migrationBuilder.CreateTable(
                name: "Reactions",
                schema: "AuthMVC",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Value = table.Column<string>(type: "TEXT", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false),
                    rater = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reactions_AspNetUsers_UserName",
                        column: x => x.UserName,
                        principalSchema: "AuthMVC",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reactions_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalSchema: "AuthMVC",
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_BlogId",
                schema: "AuthMVC",
                table: "Reactions",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_UserName",
                schema: "AuthMVC",
                table: "Reactions",
                column: "UserName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reactions",
                schema: "AuthMVC");

            migrationBuilder.CreateTable(
                name: "Ratings",
                schema: "AuthMVC",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    Value = table.Column<string>(type: "TEXT", nullable: false),
                    rater = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_AspNetUsers_UserName",
                        column: x => x.UserName,
                        principalSchema: "AuthMVC",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ratings_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalSchema: "AuthMVC",
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_BlogId",
                schema: "AuthMVC",
                table: "Ratings",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserName",
                schema: "AuthMVC",
                table: "Ratings",
                column: "UserName");
        }
    }
}
