using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolProject.Infarastructure.Migrations
{
    /// <inheritdoc />
    public partial class ViewsAndProceduresFunctions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ViewDepartment",
                columns: table => new
                {
                    DID = table.Column<int>(type: "int", nullable: false),
                    DNameAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DNameEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ViewDepartment");
        }
    }
}
