using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal.BD.Migrations
{
    public partial class HospitalesPublicos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "CentrosSalud",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "HospitalesPublicos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 80, nullable: false),
                    Telefono = table.Column<string>(maxLength: 80, nullable: false),
                    Direccion = table.Column<string>(maxLength: 80, nullable: false),
                    URLPagina = table.Column<string>(maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalesPublicos", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 1,
                column: "Telefono",
                value: "(291)4822622");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 2,
                column: "Telefono",
                value: "(291) 4811397");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 3,
                column: "Telefono",
                value: "(291) 4840157");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 4,
                column: "Telefono",
                value: "(291) 4862444");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 5,
                column: "Telefono",
                value: "(291) 4815400");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 6,
                column: "Telefono",
                value: "(291) 4888350");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 7,
                column: "Telefono",
                value: "(291) 4889859");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 8,
                column: "Telefono",
                value: "(291) 4821674");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 9,
                column: "Telefono",
                value: "(291) 4565569");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 10,
                column: "Telefono",
                value: "(291) 4918250");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 11,
                column: "Telefono",
                value: "(291) 4511862");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 12,
                column: "Telefono",
                value: "(291) 4554524");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 13,
                column: "Telefono",
                value: "(291) 4814880");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 14,
                column: "Telefono",
                value: "(291) 4556898");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 15,
                column: "Telefono",
                value: "(291) 4889026");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 16,
                column: "Telefono",
                value: "(291) 4810938");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 17,
                column: "Telefono",
                value: "(291) 4565567");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 18,
                column: "Telefono",
                value: "(291) 4554626");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 19,
                column: "Telefono",
                value: "(291) 4847220");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 20,
                column: "Telefono",
                value: "(291) 4546309");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 21,
                column: "Telefono",
                value: "(291) 4573132");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 22,
                column: "Telefono",
                value: "(291) 4565592");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 23,
                column: "Telefono",
                value: "(291) 4888351");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 24,
                column: "Telefono",
                value: "(291) 4550257");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 25,
                column: "Telefono",
                value: "(291) 4552088");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 26,
                column: "Telefono",
                value: "(291) 4552417");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 27,
                column: "Telefono",
                value: "(291) 4565562");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 28,
                column: "Telefono",
                value: "(291) 4556878");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 29,
                column: "Telefono",
                value: "(291) 4888267");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 30,
                column: "Telefono",
                value: "(291) 4888268");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 31,
                column: "Telefono",
                value: "(291) 4556939");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 32,
                column: "Telefono",
                value: "(291) 4862440");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 33,
                column: "Telefono",
                value: "(291) 4565559");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 34,
                column: "Telefono",
                value: "(291) 4556927");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 35,
                column: "Telefono",
                value: "(291) 4821625");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 36,
                column: "Telefono",
                value: "(291) 4570427");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 37,
                column: "Telefono",
                value: "(291) 4888366");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 38,
                column: "Telefono",
                value: "(291) 4550211");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 39,
                column: "Telefono",
                value: "(291) 4570474");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 40,
                column: "Telefono",
                value: "(291) 4815419");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 41,
                column: "Telefono",
                value: "(291) 4554598");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 42,
                column: "Telefono",
                value: "(291) 4565581");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 43,
                column: "Telefono",
                value: "(291) 4810155");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 44,
                column: "Telefono",
                value: "(291) 4885679");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 45,
                column: "Telefono",
                value: "(291) 4552271");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 46,
                column: "Telefono",
                value: "(291) 4813677");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 47,
                column: "Telefono",
                value: "(291) 4888365");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 48,
                column: "Telefono",
                value: "(291) 4817321");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 49,
                column: "Telefono",
                value: "(291) 4862447");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 50,
                column: "Telefono",
                value: "(291) 4817261");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 51,
                column: "Telefono",
                value: "(291) 4811080");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 52,
                column: "Telefono",
                value: "(291) 4550240");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 53,
                column: "Telefono",
                value: "(291) 4565591");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 54,
                column: "Telefono",
                value: "(291) 4552418");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 55,
                column: "Telefono",
                value: "(291) 4560139");

            migrationBuilder.InsertData(
                table: "HospitalesPublicos",
                columns: new[] { "Id", "Direccion", "Nombre", "Telefono", "URLPagina" },
                values: new object[,]
                {
                    { 2, "Estomba 968", "Hospital Municipal de Agudos Dr. Leónidas Lucero", "(291) 4598484", "http://www.hmabb.gov.ar/" },
                    { 1, "Avda. Lainez 2401", "Hospital Interzonal Dr. José Penna", "(291) 4593600", "http://www.hospitalpenna.com.ar/" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HospitalesPublicos");

            migrationBuilder.AlterColumn<int>(
                name: "Telefono",
                table: "CentrosSalud",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 80);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 1,
                column: "Telefono",
                value: 4822622);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 2,
                column: "Telefono",
                value: 4811397);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 3,
                column: "Telefono",
                value: 4840157);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 4,
                column: "Telefono",
                value: 4862444);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 5,
                column: "Telefono",
                value: 4815400);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 6,
                column: "Telefono",
                value: 4888350);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 7,
                column: "Telefono",
                value: 4889859);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 8,
                column: "Telefono",
                value: 4821674);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 9,
                column: "Telefono",
                value: 4565569);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 10,
                column: "Telefono",
                value: 4918250);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 11,
                column: "Telefono",
                value: 4511862);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 12,
                column: "Telefono",
                value: 4554524);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 13,
                column: "Telefono",
                value: 4814880);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 14,
                column: "Telefono",
                value: 4556898);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 15,
                column: "Telefono",
                value: 4889026);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 16,
                column: "Telefono",
                value: 4810938);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 17,
                column: "Telefono",
                value: 4565567);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 18,
                column: "Telefono",
                value: 4554626);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 19,
                column: "Telefono",
                value: 4847220);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 20,
                column: "Telefono",
                value: 4546309);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 21,
                column: "Telefono",
                value: 4573132);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 22,
                column: "Telefono",
                value: 4565592);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 23,
                column: "Telefono",
                value: 4888351);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 24,
                column: "Telefono",
                value: 4550257);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 25,
                column: "Telefono",
                value: 4552088);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 26,
                column: "Telefono",
                value: 4552417);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 27,
                column: "Telefono",
                value: 4565562);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 28,
                column: "Telefono",
                value: 4556878);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 29,
                column: "Telefono",
                value: 4888267);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 30,
                column: "Telefono",
                value: 4888268);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 31,
                column: "Telefono",
                value: 4556939);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 32,
                column: "Telefono",
                value: 4862440);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 33,
                column: "Telefono",
                value: 4565559);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 34,
                column: "Telefono",
                value: 4556927);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 35,
                column: "Telefono",
                value: 4821625);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 36,
                column: "Telefono",
                value: 4570427);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 37,
                column: "Telefono",
                value: 4888366);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 38,
                column: "Telefono",
                value: 4550211);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 39,
                column: "Telefono",
                value: 4570474);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 40,
                column: "Telefono",
                value: 4815419);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 41,
                column: "Telefono",
                value: 4554598);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 42,
                column: "Telefono",
                value: 4565581);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 43,
                column: "Telefono",
                value: 4810155);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 44,
                column: "Telefono",
                value: 4885679);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 45,
                column: "Telefono",
                value: 4552271);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 46,
                column: "Telefono",
                value: 4813677);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 47,
                column: "Telefono",
                value: 4888365);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 48,
                column: "Telefono",
                value: 4817321);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 49,
                column: "Telefono",
                value: 4862447);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 50,
                column: "Telefono",
                value: 4817261);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 51,
                column: "Telefono",
                value: 4811080);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 52,
                column: "Telefono",
                value: 4550240);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 53,
                column: "Telefono",
                value: 4565591);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 54,
                column: "Telefono",
                value: 4552418);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 55,
                column: "Telefono",
                value: 4560139);
        }
    }
}
