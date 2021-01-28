using Microsoft.EntityFrameworkCore.Migrations;

namespace Cwiczenia11.Migrations
{
    public partial class AddedRelationPrescriptionPatient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdPatient",
                schema: "auto_generated",
                table: "Prescriptions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "patientIdPatient",
                schema: "auto_generated",
                table: "Prescriptions",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                schema: "auto_generated",
                table: "Patients",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                schema: "auto_generated",
                table: "Patients",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                schema: "auto_generated",
                table: "Doctors",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                schema: "auto_generated",
                table: "Doctors",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                schema: "auto_generated",
                table: "Doctors",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_patientIdPatient",
                schema: "auto_generated",
                table: "Prescriptions",
                column: "patientIdPatient");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Patients_patientIdPatient",
                schema: "auto_generated",
                table: "Prescriptions",
                column: "patientIdPatient",
                principalSchema: "auto_generated",
                principalTable: "Patients",
                principalColumn: "IdPatient",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Patients_patientIdPatient",
                schema: "auto_generated",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_Prescriptions_patientIdPatient",
                schema: "auto_generated",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "IdPatient",
                schema: "auto_generated",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "patientIdPatient",
                schema: "auto_generated",
                table: "Prescriptions");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                schema: "auto_generated",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                schema: "auto_generated",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                schema: "auto_generated",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                schema: "auto_generated",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                schema: "auto_generated",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
