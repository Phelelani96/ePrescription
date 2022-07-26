using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ePrescription.Data.Migrations
{
    public partial class QualificationSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "1cdc5bd1-c710-4353-8667-e5c7a8783791");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "59805ab6-eaee-4c65-ac15-c94184a0e7f2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "432418c6-f2e3-4056-94f3-60d4782e6422");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "d161f403-c283-4392-816f-9c5fcad1b0bf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-aec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9582bb2-8a26-4e69-9e5e-8c359c9f81b1", "AQAAAAEAACcQAAAAEIdWqdibLMUTmb2u+zP2jPH5LrgxHVSXW3nBH80ZekilsJNKEtQi48SPeVjj1PHk7A==", "cacda607-d09d-4f8c-965b-0e5b98d8929c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "fb24c511-af42-4459-8734-a2c3ea285b0c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "2a0c3633-1f96-40c2-ac19-6354ec8a6e9e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "385cdf60-5113-4024-b95f-49f6cbe9ef7a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "5fcd257b-cdce-40d1-bbf5-bdb4fcf95a6f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-aec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53f5e724-6eef-4105-948d-86ededfdebd4", "AQAAAAEAACcQAAAAEGZxc2Q5z7ck/kEAU4FukolhjCSddZY+e7bgeLEL/qFPntevX35JFYDV8+eon+khLw==", "c62de9c9-16c1-40da-b8c0-d7798e8351d3" });
        }
    }
}
