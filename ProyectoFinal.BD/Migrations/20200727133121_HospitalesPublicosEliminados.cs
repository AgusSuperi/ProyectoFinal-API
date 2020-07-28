using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal.BD.Migrations
{
    public partial class HospitalesPublicosEliminados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HospitalesPublicos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HospitalesPublicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direccion = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    ImagenURL = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Restriccion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    URLPagina = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalesPublicos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "HospitalesPublicos",
                columns: new[] { "Id", "Direccion", "ImagenURL", "Nombre", "Restriccion", "Telefono", "URLPagina" },
                values: new object[,]
                {
                    { 1, "Avda. Lainez 2401", "hospitalpenna.png", "Hospital Interzonal Dr. José Penna", "Atiende a pacientes de Bahía Blanca y de toda la Región Sanitaria I", "(291) 4593600", "hospitalpenna.com.ar" },
                    { 2, "Estomba 968", "hospitalmunicipal.png", "Hospital Municipal de Agudos Dr. Leónidas Lucero", "Atiende solo a individuos domiciliados en Bahía Blanca", "(291) 4598484", "hmabb.gov.ar" },
                    { 3, "Florida 1450", "hospitalmilitar.png", "Hospital Militar", "", "(291) 4881828", "sanidad.ejercito.mil.ar" },
                    { 4, "Harris 3599", "hospitalingwhite.png", "Hospital Menor Ing. White", "", "(291)  4573132", "hospital-menor-ing-white.negocio.site" }
                });
        }
    }
}
