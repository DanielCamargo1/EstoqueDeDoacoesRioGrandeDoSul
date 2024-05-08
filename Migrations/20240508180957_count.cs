using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciamentoDeEstoqueDoacoes.Migrations
{
    public partial class count : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Relacoes");

            migrationBuilder.AddColumn<int>(
                name: "contAlimento",
                table: "Doacoes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "contMateriais",
                table: "Doacoes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "contOutros",
                table: "Doacoes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "contRoupa",
                table: "Doacoes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "contAlimento",
                table: "Doacoes");

            migrationBuilder.DropColumn(
                name: "contMateriais",
                table: "Doacoes");

            migrationBuilder.DropColumn(
                name: "contOutros",
                table: "Doacoes");

            migrationBuilder.DropColumn(
                name: "contRoupa",
                table: "Doacoes");

            migrationBuilder.CreateTable(
                name: "Relacoes",
                columns: table => new
                {
                    GridRadios = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumAlimentos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relacoes", x => x.GridRadios);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
