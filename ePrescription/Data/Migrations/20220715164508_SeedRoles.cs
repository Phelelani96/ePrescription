using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ePrescription.Data.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "b23dbfe9-eb0f-4849-89c4-8c181771f0a0", "Admin", "ADMIN" },
                    { "2", "49585ad9-617d-41e5-b915-1618a04b4119", "Doctor", "DOCTOR" },
                    { "3", "64f5398f-b341-4637-af60-4750fc0b7062", "Pharmacist", "PHARMACIST" },
                    { "4", "8bb7abd8-5396-48be-a0be-ed6e5efeebc7", "Patient", "PATIENT" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4");
        }
    }
}
