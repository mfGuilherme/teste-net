using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebCRUDTESTE.Migrations
{
    public partial class VendasEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    VendaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    qtdVenda = table.Column<int>(type: "int", nullable: false),
                    VlrUnitarioVenda = table.Column<int>(type: "int", nullable: false),
                    vlrTotalVenda = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.VendaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vendas");
        }
    }
}
