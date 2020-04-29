using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal.BD.Migrations
{
    public partial class CreacionModelos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CentrosSalud",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 80, nullable: false),
                    Telefono = table.Column<int>(nullable: false),
                    Direccion = table.Column<string>(maxLength: 80, nullable: false),
                    HorarioAtencion = table.Column<string>(maxLength: 80, nullable: false),
                    RestriccionEdad = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentrosSalud", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colectivos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Linea = table.Column<string>(maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colectivos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Especialidades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PracticasDiagnosticos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PracticasDiagnosticos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ColectivosCentrosSalud",
                columns: table => new
                {
                    CentroSaludId = table.Column<int>(nullable: false),
                    ColectivoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColectivosCentrosSalud", x => new { x.CentroSaludId, x.ColectivoId });
                    table.ForeignKey(
                        name: "FK_ColectivosCentrosSalud_CentrosSalud_CentroSaludId",
                        column: x => x.CentroSaludId,
                        principalTable: "CentrosSalud",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ColectivosCentrosSalud_Colectivos_ColectivoId",
                        column: x => x.ColectivoId,
                        principalTable: "Colectivos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EspecialidadesCentrosSalud",
                columns: table => new
                {
                    CentroSaludId = table.Column<int>(nullable: false),
                    EspecialidadId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EspecialidadesCentrosSalud", x => new { x.CentroSaludId, x.EspecialidadId });
                    table.ForeignKey(
                        name: "FK_EspecialidadesCentrosSalud_CentrosSalud_CentroSaludId",
                        column: x => x.CentroSaludId,
                        principalTable: "CentrosSalud",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EspecialidadesCentrosSalud_Especialidades_EspecialidadId",
                        column: x => x.EspecialidadId,
                        principalTable: "Especialidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PracticasDiagnosticoCentrosSalud",
                columns: table => new
                {
                    CentroSaludId = table.Column<int>(nullable: false),
                    PracticaDiagnosticoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PracticasDiagnosticoCentrosSalud", x => new { x.CentroSaludId, x.PracticaDiagnosticoId });
                    table.ForeignKey(
                        name: "FK_PracticasDiagnosticoCentrosSalud_CentrosSalud_CentroSaludId",
                        column: x => x.CentroSaludId,
                        principalTable: "CentrosSalud",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PracticasDiagnosticoCentrosSalud_PracticasDiagnosticos_PracticaDiagnosticoId",
                        column: x => x.PracticaDiagnosticoId,
                        principalTable: "PracticasDiagnosticos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ColectivosCentrosSalud_ColectivoId",
                table: "ColectivosCentrosSalud",
                column: "ColectivoId");

            migrationBuilder.CreateIndex(
                name: "IX_EspecialidadesCentrosSalud_EspecialidadId",
                table: "EspecialidadesCentrosSalud",
                column: "EspecialidadId");

            migrationBuilder.CreateIndex(
                name: "IX_PracticasDiagnosticoCentrosSalud_PracticaDiagnosticoId",
                table: "PracticasDiagnosticoCentrosSalud",
                column: "PracticaDiagnosticoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColectivosCentrosSalud");

            migrationBuilder.DropTable(
                name: "EspecialidadesCentrosSalud");

            migrationBuilder.DropTable(
                name: "PracticasDiagnosticoCentrosSalud");

            migrationBuilder.DropTable(
                name: "Colectivos");

            migrationBuilder.DropTable(
                name: "Especialidades");

            migrationBuilder.DropTable(
                name: "CentrosSalud");

            migrationBuilder.DropTable(
                name: "PracticasDiagnosticos");
        }
    }
}
