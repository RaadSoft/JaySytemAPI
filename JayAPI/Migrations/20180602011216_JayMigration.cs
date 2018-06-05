using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace JayAPI.Migrations
{
    public partial class JayMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    bairro = table.Column<string>(nullable: true),
                    cep = table.Column<string>(nullable: true),
                    cidade = table.Column<string>(nullable: true),
                    endereco = table.Column<string>(nullable: true),
                    numero = table.Column<string>(nullable: true),
                    uf = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cnpj = table.Column<string>(nullable: true),
                    enderecoCobrancaid = table.Column<int>(nullable: true),
                    enderecoEntregaid = table.Column<int>(nullable: true),
                    enderecoid = table.Column<int>(nullable: true),
                    ie = table.Column<string>(nullable: true),
                    nomeFantasia = table.Column<string>(nullable: true),
                    pessoaJuridica = table.Column<bool>(nullable: false),
                    razaoSocial = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Clientes_Endereco_enderecoCobrancaid",
                        column: x => x.enderecoCobrancaid,
                        principalTable: "Endereco",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clientes_Endereco_enderecoEntregaid",
                        column: x => x.enderecoEntregaid,
                        principalTable: "Endereco",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clientes_Endereco_enderecoid",
                        column: x => x.enderecoid,
                        principalTable: "Endereco",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedores",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cnpj = table.Column<string>(nullable: true),
                    enderecoCobrancaid = table.Column<int>(nullable: true),
                    enderecoEntregaid = table.Column<int>(nullable: true),
                    enderecoid = table.Column<int>(nullable: true),
                    ie = table.Column<string>(nullable: true),
                    nomeFantasia = table.Column<string>(nullable: true),
                    pessoaJuridica = table.Column<bool>(nullable: false),
                    razaoSocial = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedores", x => x.id);
                    table.ForeignKey(
                        name: "FK_Fornecedores_Endereco_enderecoCobrancaid",
                        column: x => x.enderecoCobrancaid,
                        principalTable: "Endereco",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fornecedores_Endereco_enderecoEntregaid",
                        column: x => x.enderecoEntregaid,
                        principalTable: "Endereco",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fornecedores_Endereco_enderecoid",
                        column: x => x.enderecoid,
                        principalTable: "Endereco",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_enderecoCobrancaid",
                table: "Clientes",
                column: "enderecoCobrancaid");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_enderecoEntregaid",
                table: "Clientes",
                column: "enderecoEntregaid");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_enderecoid",
                table: "Clientes",
                column: "enderecoid");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedores_enderecoCobrancaid",
                table: "Fornecedores",
                column: "enderecoCobrancaid");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedores_enderecoEntregaid",
                table: "Fornecedores",
                column: "enderecoEntregaid");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedores_enderecoid",
                table: "Fornecedores",
                column: "enderecoid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Fornecedores");

            migrationBuilder.DropTable(
                name: "Endereco");
        }
    }
}
