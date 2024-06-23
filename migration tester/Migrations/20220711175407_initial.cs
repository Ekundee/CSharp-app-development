using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace migration_tester.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tests",
                columns: table => new
                {
                    one = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    two = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    three = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tests", x => x.one);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tests");
        }
    }
}
