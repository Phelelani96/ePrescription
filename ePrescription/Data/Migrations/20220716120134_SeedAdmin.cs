using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ePrescription.Data.Migrations
{
    public partial class SeedAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ffb992f3-f4aa-438c-aa1c-2fa2d65d0b8d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "8eb3317c-b898-42ee-bc14-6acd1888a356");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "cc336820-c0e6-4cee-b707-c390cacfccfa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "53e05884-04fe-40b0-986c-49db502407a2");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IDNumber", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PracticeId", "QualificationId", "RegistrationNo", "SecurityStamp", "SuburbID", "TwoFactorEnabled", "UserName" },
                values: new object[] { "abc-123-ABC-246-aec", 0, "14 8th Avenue", null, "30f930f7-54cb-4bbd-bef3-8451ea9e0fb2", "Admin", "tonystark@gmail.com", true, "Tony", "8611262654879", "Stark", false, null, "TONYSTARK@GMAIL.COM", "TONYSTARK@GMAIL.COM", "AQAAAAEAACcQAAAAEMB4RoTvY1vR6VUeLHQYWGa/RDk924TU+zg6DhIOtKlvc7cnDNIqFlLKw8GaRWU+Fw==", "0780509071", true, null, null, null, "dd118e67-319d-4236-bac9-db9af06b4aba", 1, false, "tonystark@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "abc-123-ABC-246-aec" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "abc-123-ABC-246-aec" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-aec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "b23dbfe9-eb0f-4849-89c4-8c181771f0a0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "49585ad9-617d-41e5-b915-1618a04b4119");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "64f5398f-b341-4637-af60-4750fc0b7062");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "8bb7abd8-5396-48be-a0be-ed6e5efeebc7");
        }
    }
}
