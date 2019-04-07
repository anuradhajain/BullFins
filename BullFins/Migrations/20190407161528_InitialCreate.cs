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

            migrationBuilder.CreateTable(
                name: "StockStatistics",
                columns: table => new
                {
                    symbol = table.Column<string>(nullable: false),
                    dividendRate = table.Column<decimal>(nullable: false),
                    revenue = table.Column<decimal>(nullable: false),
                    grossProfit = table.Column<decimal>(nullable: false),
                    cash = table.Column<decimal>(nullable: false),
                    debt = table.Column<decimal>(nullable: false),
                    revenuePerShare = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockStatistics", x => x.symbol);
                });

            migrationBuilder.CreateTable(
                name: "SymbolFinancials",
                columns: table => new
                {
                    symbol = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SymbolFinancials", x => x.symbol);
                });

            migrationBuilder.CreateTable(
                name: "Financials",
                columns: table => new
                {
                    reportdate = table.Column<string>(nullable: false),
                    grossprofit = table.Column<decimal>(nullable: false),
                    totalrevenue = table.Column<decimal>(nullable: false),
                    totalassets = table.Column<decimal>(nullable: false),
                    totalliabilities = table.Column<decimal>(nullable: false),
                    totalcash = table.Column<decimal>(nullable: false),
                    cashflow = table.Column<decimal>(nullable: false),
                    SymbolFinancialsymbol = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Financials", x => x.reportdate);
                    table.ForeignKey(
                        name: "FK_Financials_SymbolFinancials_SymbolFinancialsymbol",
                        column: x => x.SymbolFinancialsymbol,
                        principalTable: "SymbolFinancials",
                        principalColumn: "symbol",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Financials_SymbolFinancialsymbol",
                table: "Financials",
                column: "SymbolFinancialsymbol");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Financials");

            migrationBuilder.DropTable(
                name: "StockStatistics");

            migrationBuilder.DropTable(
                name: "SymbolFinancials");
        }
    }
}
