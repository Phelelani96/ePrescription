using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ePrescription.Migrations
{
    public partial class UserStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "bb8ba6ba-b11a-406d-b4f7-c046cbfa1850");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "50518692-d0e8-404b-806c-171c06a73915");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "079cdee8-eb19-4c3f-9088-01f35516363c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "be002997-9a49-461c-b59a-2bbbd19dce35");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-aec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "Status" },
                values: new object[] { "f62ffe09-8b9a-4d35-a9a2-31c6d41995ec", "AQAAAAEAACcQAAAAEH8f6yGWJkS4Z8bBgNc6pT6cn4/E7aIWMYoqooq1gGqqnunftCwVWRs2DUUAkjEOSQ==", "5a24785a-f831-4d3e-aeb8-427210038903", "Active" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "8b490c10-7502-44fb-b6df-c772cc59863a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "ddebf2cb-3ec3-430c-8b30-c7346500f31b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "fb48519f-1f29-4f51-adcd-1ca0c59f0148");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "38c3cada-c706-46d4-adf7-b52e536ca28d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-aec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70a7c7f1-edef-4acb-b827-fe24cf93cd82", "AQAAAAEAACcQAAAAEDGxZrsdA4sMEjlGpRNQ+D13H8kmMFI5SL02kO/LB6xI/GJ4DqkD/uiDo2LItdbJaA==", "35097686-6740-44b4-97cf-6b7f20cdefcc" });
        }
    }
}
