using Microsoft.EntityFrameworkCore.Migrations;

namespace webapp.Migrations
{
    public partial class SeedEmployeesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "Department", "Mail", "Name" },
                values: new object[] { 1, "Ain-Shams", 22, "Software development", "Omar.diaaeldin@nagwa.com", "Omar" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
