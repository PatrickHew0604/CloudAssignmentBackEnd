using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloudAssignment_BackEnd.Migrations.EConsultationDB
{
    /// <inheritdoc />
    public partial class AddedApplicationDatabaseSchemaV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Consultations_ConsultationID1",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalCertificates_Consultations_ConsultationID1",
                table: "MedicalCertificates");

            migrationBuilder.DropIndex(
                name: "IX_MedicalCertificates_ConsultationID1",
                table: "MedicalCertificates");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_ConsultationID1",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "ConsultationID1",
                table: "MedicalCertificates");

            migrationBuilder.DropColumn(
                name: "ConsultationID1",
                table: "Feedbacks");

            migrationBuilder.AlterColumn<Guid>(
                name: "ConsultationID",
                table: "MedicalCertificates",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "ConsultationID",
                table: "Feedbacks",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCertificates_ConsultationID",
                table: "MedicalCertificates",
                column: "ConsultationID");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_ConsultationID",
                table: "Feedbacks",
                column: "ConsultationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Consultations_ConsultationID",
                table: "Feedbacks",
                column: "ConsultationID",
                principalTable: "Consultations",
                principalColumn: "ConsultationID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalCertificates_Consultations_ConsultationID",
                table: "MedicalCertificates",
                column: "ConsultationID",
                principalTable: "Consultations",
                principalColumn: "ConsultationID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Consultations_ConsultationID",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalCertificates_Consultations_ConsultationID",
                table: "MedicalCertificates");

            migrationBuilder.DropIndex(
                name: "IX_MedicalCertificates_ConsultationID",
                table: "MedicalCertificates");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_ConsultationID",
                table: "Feedbacks");

            migrationBuilder.AlterColumn<string>(
                name: "ConsultationID",
                table: "MedicalCertificates",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "ConsultationID1",
                table: "MedicalCertificates",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "ConsultationID",
                table: "Feedbacks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "ConsultationID1",
                table: "Feedbacks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCertificates_ConsultationID1",
                table: "MedicalCertificates",
                column: "ConsultationID1");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_ConsultationID1",
                table: "Feedbacks",
                column: "ConsultationID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Consultations_ConsultationID1",
                table: "Feedbacks",
                column: "ConsultationID1",
                principalTable: "Consultations",
                principalColumn: "ConsultationID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalCertificates_Consultations_ConsultationID1",
                table: "MedicalCertificates",
                column: "ConsultationID1",
                principalTable: "Consultations",
                principalColumn: "ConsultationID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
