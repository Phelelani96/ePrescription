using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ePrescription.Data.Migrations
{
    public partial class PharmacymodelUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "88b4943f-779f-4d51-bcac-fe6a5c37a595");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "984af5bf-2e41-46b7-a376-a3fb60adae8f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "a8695a36-91b1-4620-ae25-86ec58c8f77c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "b42c2170-fbba-4010-9ec6-753352295baf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-aec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8c569eb-b4bd-4309-9a8e-091f0ab81972", "AQAAAAEAACcQAAAAEJA0gRrBRqwwJ15LfFdPR3n7T/dZyxWM+FT9jSrF/MV5QPIDbIEgHnG3OcFkCOuXIA==", "9997902f-6f3f-4e33-8521-9fe7eadf13b7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "e2f21226-83cd-4d94-86be-29e0d50e4e6b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "3c6d66d7-c1d8-4a15-902e-c3d6eb818463");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "1fd13d9c-908c-4ba9-9b7b-e63d4581d245");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "2df58747-ee2b-4a3a-bc63-4cb3943e4ab9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-aec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2221d56d-0c11-4c7b-a2f7-8f23185ef83e", "AQAAAAEAACcQAAAAEMzu3GIwJgab9a26mQQnyGDIZLQG3bQR1SlmGwAXT1yhBUh8xHl2l6KgHUMYCVqeTA==", "9127bf27-aa52-4452-bf4b-2427b5ce3927" });
        }
    }
}
