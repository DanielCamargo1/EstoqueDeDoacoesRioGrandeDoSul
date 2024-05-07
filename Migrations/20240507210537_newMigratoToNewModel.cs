using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciamentoDeEstoqueDoacoes.Migrations
{
    public partial class newMigratoToNewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Relacoes",
                columns: table => new
                {
                    GridRadios = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relacoes", x => x.GridRadios);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Relacoes");
        }
    }
}
