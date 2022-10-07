using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraestrutura.Data.Migrations
{
    public partial class v0001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    CnpjCpf = table.Column<string>(type: "text", nullable: true),
                    DateDeNascimento = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CelularPrincipal = table.Column<string>(type: "text", nullable: true),
                    EmailPrincipal = table.Column<string>(type: "text", nullable: true),
                    Ativo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnotacaoDeCliente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Data = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Texto = table.Column<string>(type: "text", nullable: true),
                    IdCliente = table.Column<Guid>(type: "uuid", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnotacaoDeCliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnotacaoDeCliente_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EnderecoDoCliente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Cep = table.Column<string>(type: "text", nullable: true),
                    Logradouro = table.Column<string>(type: "text", nullable: true),
                    NumeroLogradouro = table.Column<string>(type: "text", nullable: true),
                    ComplementoLogradouro = table.Column<string>(type: "text", nullable: true),
                    Bairro = table.Column<string>(type: "text", nullable: true),
                    Municipio = table.Column<string>(type: "text", nullable: true),
                    Uf = table.Column<string>(type: "text", nullable: true),
                    IdCliente = table.Column<Guid>(type: "uuid", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnderecoDoCliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnderecoDoCliente_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnotacaoDeCliente_ClienteId",
                table: "AnotacaoDeCliente",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecoDoCliente_ClienteId",
                table: "EnderecoDoCliente",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnotacaoDeCliente");

            migrationBuilder.DropTable(
                name: "EnderecoDoCliente");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
