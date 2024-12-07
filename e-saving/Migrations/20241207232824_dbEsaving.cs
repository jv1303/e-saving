using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_saving.Migrations
{
    /// <inheritdoc />
    public partial class dbEsaving : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    CpfCliente = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    NomeCliente = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    SenhaCliente = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    EmailCliente = table.Column<string>(type: "TEXT", maxLength: 130, nullable: false),
                    ItensDescartados = table.Column<int>(type: "INTEGER", nullable: false),
                    FotoPerfilCliente = table.Column<byte[]>(type: "BLOB", nullable: false),
                    PontosClientes = table.Column<int>(type: "INTEGER", nullable: false),
                    PontoFavoritoCliente = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.CpfCliente);
                });

            migrationBuilder.CreateTable(
                name: "compradores",
                columns: table => new
                {
                    CnpjComprador = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    FotoDePerfilComprador = table.Column<byte[]>(type: "BLOB", nullable: false),
                    EmailComprador = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    SenhaComprador = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    RazaoSocial = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_compradores", x => x.CnpjComprador);
                });

            migrationBuilder.CreateTable(
                name: "estoques",
                columns: table => new
                {
                    IdEstoque = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Quantidade = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estoques", x => x.IdEstoque);
                });

            migrationBuilder.CreateTable(
                name: "parceiros",
                columns: table => new
                {
                    CpfParceiro = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    SenhaParceiro = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    EmailParceiro = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    NomeParceiro = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    FotoPerfilParceiro = table.Column<byte[]>(type: "BLOB", nullable: false),
                    PontosParceiro = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parceiros", x => x.CpfParceiro);
                });

            migrationBuilder.CreateTable(
                name: "compra",
                columns: table => new
                {
                    CpnjComprador = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    IdEstoque = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_compra", x => new { x.IdEstoque, x.CpnjComprador });
                    table.ForeignKey(
                        name: "FK_compra_compradores_CpnjComprador",
                        column: x => x.CpnjComprador,
                        principalTable: "compradores",
                        principalColumn: "CnpjComprador",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_compra_estoques_IdEstoque",
                        column: x => x.IdEstoque,
                        principalTable: "estoques",
                        principalColumn: "IdEstoque",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "funcionarios",
                columns: table => new
                {
                    CpfFuncionario = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    SenhaFuncionario = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    NomeUsuario = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    EmailConstitucional = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    NomeFuncionario = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    FotoPerfilFuncionario = table.Column<byte[]>(type: "BLOB", nullable: false),
                    IdEstoque = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_funcionarios", x => x.CpfFuncionario);
                    table.ForeignKey(
                        name: "FK_funcionarios_estoques_IdEstoque",
                        column: x => x.IdEstoque,
                        principalTable: "estoques",
                        principalColumn: "IdEstoque",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "contasBanco",
                columns: table => new
                {
                    Agencia = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Banco = table.Column<string>(type: "TEXT", maxLength: 75, nullable: false),
                    NumeroConta = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Bandeira = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    CpfParceiro = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    CnpjComprador = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    CpfCliente = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contasBanco", x => new { x.Agencia, x.Banco, x.NumeroConta });
                    table.ForeignKey(
                        name: "FK_contasBanco_clientes_CpfCliente",
                        column: x => x.CpfCliente,
                        principalTable: "clientes",
                        principalColumn: "CpfCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contasBanco_compradores_CnpjComprador",
                        column: x => x.CnpjComprador,
                        principalTable: "compradores",
                        principalColumn: "CnpjComprador",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contasBanco_parceiros_CpfParceiro",
                        column: x => x.CpfParceiro,
                        principalTable: "parceiros",
                        principalColumn: "CpfParceiro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pontosColeta",
                columns: table => new
                {
                    IdPontoColeta = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CnpjParceiro = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    ItensColetados = table.Column<int>(type: "INTEGER", nullable: false),
                    Pontuacao = table.Column<int>(type: "INTEGER", nullable: false),
                    CpfParceiro = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pontosColeta", x => x.IdPontoColeta);
                    table.ForeignKey(
                        name: "FK_pontosColeta_parceiros_CpfParceiro",
                        column: x => x.CpfParceiro,
                        principalTable: "parceiros",
                        principalColumn: "CpfParceiro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    IdItem = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Valor = table.Column<double>(type: "REAL", nullable: false),
                    ModeloItem = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Tipo = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    IdPontoColeta = table.Column<int>(type: "INTEGER", nullable: false),
                    IdEstoque = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.IdItem);
                    table.ForeignKey(
                        name: "FK_items_estoques_IdEstoque",
                        column: x => x.IdEstoque,
                        principalTable: "estoques",
                        principalColumn: "IdEstoque",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_items_pontosColeta_IdPontoColeta",
                        column: x => x.IdPontoColeta,
                        principalTable: "pontosColeta",
                        principalColumn: "IdPontoColeta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "fornece",
                columns: table => new
                {
                    IdItem = table.Column<int>(type: "INTEGER", nullable: false),
                    CpfCliente = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    PontoColetaIdPontoColeta = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fornece", x => new { x.IdItem, x.CpfCliente });
                    table.ForeignKey(
                        name: "FK_fornece_clientes_CpfCliente",
                        column: x => x.CpfCliente,
                        principalTable: "clientes",
                        principalColumn: "CpfCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_fornece_items_IdItem",
                        column: x => x.IdItem,
                        principalTable: "items",
                        principalColumn: "IdItem",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_fornece_pontosColeta_PontoColetaIdPontoColeta",
                        column: x => x.PontoColetaIdPontoColeta,
                        principalTable: "pontosColeta",
                        principalColumn: "IdPontoColeta");
                });

            migrationBuilder.CreateIndex(
                name: "IX_compra_CpnjComprador",
                table: "compra",
                column: "CpnjComprador");

            migrationBuilder.CreateIndex(
                name: "IX_contasBanco_CnpjComprador",
                table: "contasBanco",
                column: "CnpjComprador");

            migrationBuilder.CreateIndex(
                name: "IX_contasBanco_CpfCliente",
                table: "contasBanco",
                column: "CpfCliente");

            migrationBuilder.CreateIndex(
                name: "IX_contasBanco_CpfParceiro",
                table: "contasBanco",
                column: "CpfParceiro");

            migrationBuilder.CreateIndex(
                name: "IX_fornece_CpfCliente",
                table: "fornece",
                column: "CpfCliente");

            migrationBuilder.CreateIndex(
                name: "IX_fornece_PontoColetaIdPontoColeta",
                table: "fornece",
                column: "PontoColetaIdPontoColeta");

            migrationBuilder.CreateIndex(
                name: "IX_funcionarios_IdEstoque",
                table: "funcionarios",
                column: "IdEstoque");

            migrationBuilder.CreateIndex(
                name: "IX_items_IdEstoque",
                table: "items",
                column: "IdEstoque");

            migrationBuilder.CreateIndex(
                name: "IX_items_IdPontoColeta",
                table: "items",
                column: "IdPontoColeta");

            migrationBuilder.CreateIndex(
                name: "IX_pontosColeta_CpfParceiro",
                table: "pontosColeta",
                column: "CpfParceiro");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "compra");

            migrationBuilder.DropTable(
                name: "contasBanco");

            migrationBuilder.DropTable(
                name: "fornece");

            migrationBuilder.DropTable(
                name: "funcionarios");

            migrationBuilder.DropTable(
                name: "compradores");

            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.DropTable(
                name: "estoques");

            migrationBuilder.DropTable(
                name: "pontosColeta");

            migrationBuilder.DropTable(
                name: "parceiros");
        }
    }
}
