using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ePrescription.Data.Migrations
{
    public partial class MoreSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "24eff15c-7a5e-482a-9ae5-a3bd9e0213cf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "b46034ee-9757-4f41-b07b-81c201c6bebc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "cb08b710-fa0d-4b8a-82cd-e0f68ffa4132");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "393e21c7-8ffe-4776-ba6a-995196e56d67");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-aec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51f365a3-381f-478b-8c39-d42f732365ec", "AQAAAAEAACcQAAAAEPcCHj3bw1sl8d0O0pgwCFit3NxFiugn5qYJabvyafMyFhv31UIfuzqj/ejKHAQZCg==", "4bb1ce84-f680-4522-9988-d0685bcb88b7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
