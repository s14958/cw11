using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cwiczenia11.Migrations
{
    public partial class AddPrescriptionSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { 480338007, "aadamowicz@gmail.com", "Adam", "Adamowicz" },
                    { 272612429, "ffilipowicz@gmail.com", "Filip", "Filipowicz" },
                    { 354134384, "jjanowicz@gmail.com", "Jan", "Janowicz" }
                });

            migrationBuilder.InsertData(
                schema: "auto_generated",
                table: "Medicaments",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1534530121, "AA", "A", "AAA" },
                    { 1813417295, "AA", "A", "AAA" },
                    { 1723127630, "AA", "A", "AAA" }
                });

            migrationBuilder.InsertData(
                schema: "auto_generated",
                table: "Patients",
                columns: new[] { "IdPatient", "BirthDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1411896636, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna", "Annawska" },
                    { 380588171, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jadwiga", "Jadwigowska" },
                    { 221614498, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Justyna", "Justynowska" }
                });

            migrationBuilder.InsertData(
                schema: "auto_generated",
                table: "Prescriptions",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient", "doctorIdDoctor", "patientIdPatient" },
                values: new object[,]
                {
                    { 723430261, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 480338007, 1411896636, null, null },
                    { 592198818, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 272612429, 380588171, null, null },
                    { 1804078758, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 354134384, 221614498, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 272612429);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 354134384);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 480338007);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 1534530121);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 1723127630);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 1813417295);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 221614498);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 380588171);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1411896636);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 592198818);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 723430261);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1804078758);

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
    }
}
