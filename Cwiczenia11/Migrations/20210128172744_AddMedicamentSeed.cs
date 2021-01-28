using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cwiczenia11.Migrations
{
    public partial class AddMedicamentSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 3);

            migrationBuilder.InsertData(
                schema: "auto_generated",
                table: "Doctors",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 68866063, "aadamowicz@gmail.com", "Adam", "Adamowicz" },
                    { 2144717839, "ffilipowicz@gmail.com", "Filip", "Filipowicz" },
                    { 184093209, "jjanowicz@gmail.com", "Jan", "Janowicz" }
                });

            migrationBuilder.InsertData(
                schema: "auto_generated",
                table: "Medicaments",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 25681991, "AA", "A", "AAA" },
                    { 2097999038, "AA", "A", "AAA" },
                    { 1884521769, "AA", "A", "AAA" }
                });

            migrationBuilder.InsertData(
                schema: "auto_generated",
                table: "Patients",
                columns: new[] { "IdPatient", "BirthDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 2125128178, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna", "Annawska" },
                    { 708426475, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jadwiga", "Jadwigowska" },
                    { 883142738, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Justyna", "Justynowska" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 68866063);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 184093209);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 2144717839);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 25681991);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 1884521769);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 2097999038);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 708426475);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 883142738);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 2125128178);

            migrationBuilder.InsertData(
                schema: "auto_generated",
                table: "Doctors",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "aadamowicz@gmail.com", "Adam", "Adamowicz" },
                    { 2, "ffilipowicz@gmail.com", "Filip", "Filipowicz" },
                    { 3, "jjanowicz@gmail.com", "Jan", "Janowicz" }
                });

            migrationBuilder.InsertData(
                schema: "auto_generated",
                table: "Patients",
                columns: new[] { "IdPatient", "BirthDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna", "Annawska" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jadwiga", "Jadwigowska" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Justyna", "Justynowska" }
                });
        }
    }
}
