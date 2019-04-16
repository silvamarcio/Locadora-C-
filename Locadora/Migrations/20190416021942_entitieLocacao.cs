using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Locadora.Migrations
{
    public partial class entitieLocacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocacaoId",
                table: "Filme",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Locacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RentalPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locacao", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filme_LocacaoId",
                table: "Filme",
                column: "LocacaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Filme_Locacao_LocacaoId",
                table: "Filme",
                column: "LocacaoId",
                principalTable: "Locacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filme_Locacao_LocacaoId",
                table: "Filme");

            migrationBuilder.DropTable(
                name: "Locacao");

            migrationBuilder.DropIndex(
                name: "IX_Filme_LocacaoId",
                table: "Filme");

            migrationBuilder.DropColumn(
                name: "LocacaoId",
                table: "Filme");
        }
    }
}
