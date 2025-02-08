using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloudAssignment_BackEnd.Migrations.EConsultationDB
{
    /// <inheritdoc />
    public partial class AddOneColumnintoImagesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileExtension",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileExtension",
                table: "Images");
        }
    }
}
