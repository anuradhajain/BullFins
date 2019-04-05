using Microsoft.EntityFrameworkCore.Migrations;

namespace BullFins.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    symbol = table.Column<string>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    date = table.Column<string>(nullable: true),
                    isEnabled = table.Column<bool>(nullable: false),
                    type = table.Column<string>(nullable: true),
                    iexId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.symbol);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
