using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal.BD.Migrations
{
    public partial class NuevosHospitales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "URLPagina",
                table: "HospitalesPublicos",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80);

            migrationBuilder.AddColumn<string>(
                name: "Restriccion",
                table: "HospitalesPublicos",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "HospitalesPublicos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Restriccion",
                value: "Atiende a pacientes de Bahía Blanca y de toda la Región Sanitaria I");

            migrationBuilder.UpdateData(
                table: "HospitalesPublicos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Restriccion",
                value: "Atiende solo a individuos domiciliados en Bahía Blanca");

            migrationBuilder.InsertData(
                table: "HospitalesPublicos",
                columns: new[] { "Id", "Direccion", "Nombre", "Restriccion", "Telefono", "URLPagina" },
                values: new object[,]
                {
                    { 3, "Florida 1450", "Hospital Militar Bahía Blanca", "", "(291) 4881828", "" },
                    { 4, "Harris 3599", "Hospital Menor Ing. White", "", "(291)  4573132", "https://hospital-menor-ing-white.negocio.site/" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HospitalesPublicos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HospitalesPublicos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Restriccion",
                table: "HospitalesPublicos");

            migrationBuilder.AlterColumn<string>(
                name: "URLPagina",
                table: "HospitalesPublicos",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);
        }
    }
}
