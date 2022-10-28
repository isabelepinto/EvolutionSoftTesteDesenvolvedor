using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroDePessoas.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    PessoaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Celular = table.Column<int>(type: "int", maxLength: 11, nullable: false),
                    StatusCadastro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.PessoaId);
                });

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cpf = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Cep = table.Column<int>(type: "int", nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PessoaModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pessoas_Pessoas_PessoaModelId",
                        column: x => x.PessoaModelId,
                        principalTable: "Pessoas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_PessoaModelId",
                table: "Pessoas",
                column: "PessoaModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contatos");

            migrationBuilder.DropTable(
                name: "Pessoas");
        }
    }
}
