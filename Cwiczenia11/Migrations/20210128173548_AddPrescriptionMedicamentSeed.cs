using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cwiczenia11.Migrations
{
    public partial class AddPrescriptionMedicamentSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { 927306037, "aadamowicz@gmail.com", "Adam", "Adamowicz" },
                    { 94776480, "ffilipowicz@gmail.com", "Filip", "Filipowicz" },
                    { 888681041, "jjanowicz@gmail.com", "Jan", "Janowicz" }
                });

            migrationBuilder.InsertData(
                schema: "auto_generated",
                table: "Medicaments",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 530324991, "AA", "A", "AAA" },
                    { 187348916, "AA", "A", "AAA" },
                    { 234364090, "AA", "A", "AAA" }
                });

            migrationBuilder.InsertData(
                schema: "auto_generated",
                table: "Patients",
                columns: new[] { "IdPatient", "BirthDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1705473000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna", "Annawska" },
                    { 1970573639, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jadwiga", "Jadwigowska" },
                    { 248866336, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Justyna", "Justynowska" }
                });

            migrationBuilder.InsertData(
                schema: "auto_generated",
                table: "Prescriptions",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient", "doctorIdDoctor", "patientIdPatient" },
                values: new object[,]
                {
                    { 1456020394, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 927306037, 1705473000, null, null },
                    { 103102135, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 94776480, 1970573639, null, null },
                    { 1526225485, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 888681041, 248866336, null, null }
                });

            migrationBuilder.InsertData(
                schema: "auto_generated",
                table: "Prescription_Medicaments",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[] { 530324991, 1456020394, "AAA", 44 });

            migrationBuilder.InsertData(
                schema: "auto_generated",
                table: "Prescription_Medicaments",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[] { 187348916, 103102135, "AAA", 45 });

            migrationBuilder.InsertData(
                schema: "auto_generated",
                table: "Prescription_Medicaments",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[] { 234364090, 1526225485, "AAA", 80 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 94776480);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 888681041);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 927306037);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 248866336);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1705473000);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1970573639);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 187348916, 103102135 });

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 234364090, 1526225485 });

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 530324991, 1456020394 });

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 187348916);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 234364090);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 530324991);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 103102135);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1456020394);

            migrationBuilder.DeleteData(
                schema: "auto_generated",
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1526225485);

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
    }
}
