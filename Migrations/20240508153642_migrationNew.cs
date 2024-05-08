using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciamentoDeEstoqueDoacoes.Migrations
{
    public partial class migrationNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumAlimentos",
                table: "Relacoes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumAlimentos",
                table: "Relacoes");
        }
    }
}
