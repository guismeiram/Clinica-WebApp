using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevIO.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Convenio",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    NCarteira = table.Column<string>(type: "varchar(50)", nullable: false),
                    Vencimento = table.Column<string>(type: "varchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Convenio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Especialidade",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    Crm = table.Column<string>(type: "varchar(250)", nullable: false),
                    Idade = table.Column<string>(type: "varchar(50)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(200)", nullable: false),
                    Ddd = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    Idade = table.Column<string>(type: "varchar(100)", nullable: false),
                    Rg = table.Column<string>(type: "varchar(100)", nullable: false),
                    Cpf = table.Column<string>(type: "varchar(100)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(200)", nullable: false),
                    Ddd = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPagamento",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", nullable: false),
                    Pagamentos = table.Column<int>(type: "int", nullable: false),
                    ConveniosId = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPagamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TipoPagamento_Convenio_ConveniosId",
                        column: x => x.ConveniosId,
                        principalTable: "Convenio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Bairro = table.Column<string>(type: "varchar(100)", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(100)", nullable: false),
                    Estado = table.Column<string>(type: "varchar(100)", nullable: false),
                    Pais = table.Column<string>(type: "varchar(100)", nullable: false),
                    MedicoId = table.Column<string>(type: "varchar(100)", nullable: false),
                    EnderecoId = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Endereco_Medico_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Medico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicoEspecialidade",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", nullable: false),
                    MedicoId = table.Column<string>(type: "varchar(100)", nullable: false),
                    EspecialidadeId = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicoEspecialidade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicoEspecialidade_Especialidade_EspecialidadeId",
                        column: x => x.EspecialidadeId,
                        principalTable: "Especialidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicoEspecialidade_Medico_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Medico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PacienteTipoPagamento",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", nullable: false),
                    PacienteId = table.Column<string>(type: "varchar(100)", nullable: false),
                    TipoPagamentoId = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PacienteTipoPagamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PacienteTipoPagamento_Paciente_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Paciente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PacienteTipoPagamento_TipoPagamento_TipoPagamentoId",
                        column: x => x.TipoPagamentoId,
                        principalTable: "TipoPagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clinica",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(200)", nullable: false),
                    Ddd = table.Column<string>(type: "varchar(200)", nullable: false),
                    ClinicaId = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clinica_Endereco_ClinicaId",
                        column: x => x.ClinicaId,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Consulta",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", nullable: false),
                    MedicoId = table.Column<string>(type: "varchar(100)", nullable: false),
                    ClinicaId = table.Column<string>(type: "varchar(100)", nullable: false),
                    PacienteId = table.Column<string>(type: "varchar(100)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consulta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consulta_Clinica_ClinicaId",
                        column: x => x.ClinicaId,
                        principalTable: "Clinica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consulta_Medico_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Medico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consulta_Paciente_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Paciente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clinica_ClinicaId",
                table: "Clinica",
                column: "ClinicaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_ClinicaId",
                table: "Consulta",
                column: "ClinicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_MedicoId",
                table: "Consulta",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_PacienteId",
                table: "Consulta",
                column: "PacienteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_MedicoId",
                table: "Endereco",
                column: "MedicoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MedicoEspecialidade_EspecialidadeId",
                table: "MedicoEspecialidade",
                column: "EspecialidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicoEspecialidade_MedicoId",
                table: "MedicoEspecialidade",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_PacienteTipoPagamento_PacienteId",
                table: "PacienteTipoPagamento",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_PacienteTipoPagamento_TipoPagamentoId",
                table: "PacienteTipoPagamento",
                column: "TipoPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoPagamento_ConveniosId",
                table: "TipoPagamento",
                column: "ConveniosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consulta");

            migrationBuilder.DropTable(
                name: "MedicoEspecialidade");

            migrationBuilder.DropTable(
                name: "PacienteTipoPagamento");

            migrationBuilder.DropTable(
                name: "Clinica");

            migrationBuilder.DropTable(
                name: "Especialidade");

            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "TipoPagamento");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Convenio");

            migrationBuilder.DropTable(
                name: "Medico");
        }
    }
}
