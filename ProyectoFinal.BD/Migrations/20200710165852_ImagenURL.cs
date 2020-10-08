using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal.BD.Migrations
{
    public partial class ImagenURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagenURL",
                table: "HospitalesPublicos",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImagenURL",
                table: "CentrosSalud",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagenURL",
                value: "9denoviembre.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagenURL",
                value: "12deoctubre.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagenURL",
                value: "amenghini.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagenURL",
                value: "aldearomana.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImagenURL",
                value: "anchorena.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImagenURL",
                value: "avellaneda.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Barrio", "ImagenURL" },
                values: new object[] { "Latino", "barriolatino.png" });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Barrio", "ImagenURL" },
                values: new object[] { "Obrero", "barrioobrero.png" });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImagenURL",
                value: "bellavista.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImagenURL",
                value: "cabildo.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImagenURL",
                value: "cicspurr.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImagenURL",
                value: "colon.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImagenURL",
                value: "donbosco.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImagenURL",
                value: "enriquejulio.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImagenURL",
                value: "estomba.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImagenURL",
                value: "grunbein.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImagenURL",
                value: "kilometro5.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImagenURL",
                value: "lafalda.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImagenURL",
                value: "laureanomuñiz.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImagenURL",
                value: "leandropiñeiro.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImagenURL",
                value: "leonorcapelli.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImagenURL",
                value: "lomaparaguaya.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImagenURL",
                value: "lujan.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImagenURL",
                value: "maldonado.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImagenURL",
                value: "marianomoreno.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 26,
                column: "ImagenURL",
                value: "miramar.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 27,
                column: "ImagenURL",
                value: "naposta.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImagenURL",
                value: "noroeste.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 29,
                column: "ImagenURL",
                value: "norte.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImagenURL",
                value: "nuevabelgrano.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImagenURL",
                value: "pampacentral.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImagenURL",
                value: "patagonia.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImagenURL",
                value: "pedropico.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImagenURL",
                value: "rivadavia.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImagenURL",
                value: "rosariosur.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImagenURL",
                value: "saladero.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 37,
                column: "ImagenURL",
                value: "sancayetano.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 38,
                column: "ImagenURL",
                value: "sandionisio.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 39,
                column: "ImagenURL",
                value: "sanjoseobrero.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 40,
                column: "ImagenURL",
                value: "sanchezelia.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 41,
                column: "ImagenURL",
                value: "tirofederal.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 42,
                column: "ImagenURL",
                value: "universitario.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 43,
                column: "ImagenURL",
                value: "villaamaducci.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 44,
                column: "ImagenURL",
                value: "villabordeu.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 45,
                column: "ImagenURL",
                value: "villadelfina.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 46,
                column: "ImagenURL",
                value: "villaesperanza.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 47,
                column: "ImagenURL",
                value: "villafloresta.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 48,
                column: "ImagenURL",
                value: "villagloria.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 49,
                column: "ImagenURL",
                value: "villahardinggreen.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 50,
                column: "ImagenURL",
                value: "villamitre.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 51,
                column: "ImagenURL",
                value: "villamuñiz.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 52,
                column: "ImagenURL",
                value: "villanocito.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 53,
                column: "ImagenURL",
                value: "villaressia.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 54,
                column: "ImagenURL",
                value: "villarosas.png");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 55,
                column: "ImagenURL",
                value: "villaserra.png");

            migrationBuilder.UpdateData(
                table: "HospitalesPublicos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagenURL",
                value: "hospitalpenna.png");

            migrationBuilder.UpdateData(
                table: "HospitalesPublicos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagenURL",
                value: "hospitalmunicipal.png");

            migrationBuilder.UpdateData(
                table: "HospitalesPublicos",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagenURL",
                value: "hospitalmilitar.png");

            migrationBuilder.UpdateData(
                table: "HospitalesPublicos",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagenURL",
                value: "hospitalingwhite.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagenURL",
                table: "HospitalesPublicos");

            migrationBuilder.DropColumn(
                name: "ImagenURL",
                table: "CentrosSalud");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 7,
                column: "Barrio",
                value: "Barrio Latino");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 8,
                column: "Barrio",
                value: "Barrio Obrero");
        }
    }
}
