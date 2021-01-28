using Microsoft.EntityFrameworkCore.Migrations;

namespace Cwiczenia11.Migrations
{
    public partial class AddedRelationPrescriptionPrescription_Medicament : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Details",
                schema: "auto_generated",
                table: "Prescription_Medicaments",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_Medicaments_IdPrescription",
                schema: "auto_generated",
                table: "Prescription_Medicaments",
                column: "IdPrescription");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Medicaments_Medicaments_IdMedicament",
                schema: "auto_generated",
                table: "Prescription_Medicaments",
                column: "IdMedicament",
                principalSchema: "auto_generated",
                principalTable: "Medicaments",
                principalColumn: "IdMedicament",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Medicaments_Prescriptions_IdPrescription",
                schema: "auto_generated",
                table: "Prescription_Medicaments",
                column: "IdPrescription",
                principalSchema: "auto_generated",
                principalTable: "Prescriptions",
                principalColumn: "IdPrescription",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Medicaments_Medicaments_IdMedicament",
                schema: "auto_generated",
                table: "Prescription_Medicaments");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Medicaments_Prescriptions_IdPrescription",
                schema: "auto_generated",
                table: "Prescription_Medicaments");

            migrationBuilder.DropIndex(
                name: "IX_Prescription_Medicaments_IdPrescription",
                schema: "auto_generated",
                table: "Prescription_Medicaments");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                schema: "auto_generated",
                table: "Prescription_Medicaments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
