using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectCode.Migrations
{
    public partial class AddAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "technology",
                table: "CodeDetails",
                newName: "Technology");

            migrationBuilder.RenameColumn(
                name: "gitLink",
                table: "CodeDetails",
                newName: "GitLink");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "CodeDetails",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "author",
                table: "CodeDetails",
                newName: "Author");

            migrationBuilder.RenameColumn(
                name: "codeID",
                table: "CodeDetails",
                newName: "CodeID");

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    AuthorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Authorname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expertise = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.AuthorID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.RenameColumn(
                name: "Technology",
                table: "CodeDetails",
                newName: "technology");

            migrationBuilder.RenameColumn(
                name: "GitLink",
                table: "CodeDetails",
                newName: "gitLink");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "CodeDetails",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Author",
                table: "CodeDetails",
                newName: "author");

            migrationBuilder.RenameColumn(
                name: "CodeID",
                table: "CodeDetails",
                newName: "codeID");
        }
    }
}
