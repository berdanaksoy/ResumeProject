using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumeProject.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EducationCompany3",
                table: "Abouts",
                newName: "EducationProvider3");

            migrationBuilder.RenameColumn(
                name: "EducationCompany2",
                table: "Abouts",
                newName: "EducationProvider2");

            migrationBuilder.RenameColumn(
                name: "EducationCompany",
                table: "Abouts",
                newName: "EducationProvider");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EducationProvider3",
                table: "Abouts",
                newName: "EducationCompany3");

            migrationBuilder.RenameColumn(
                name: "EducationProvider2",
                table: "Abouts",
                newName: "EducationCompany2");

            migrationBuilder.RenameColumn(
                name: "EducationProvider",
                table: "Abouts",
                newName: "EducationCompany");
        }
    }
}
