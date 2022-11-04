using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ePrescription.Migrations
{
    public partial class suburbidNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Suburb_SuburbID",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "SuburbID",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "IDNumber",
                table: "AspNetUsers",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(13)",
                oldMaxLength: 13);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "4ef72101-4504-4411-8002-37b8c424630e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "48e1ce43-b1ea-4ff9-9702-68eed9406747");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "fb20f88e-a009-43b1-a704-0c4a96005c28");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "2e6b493d-325c-4f61-993d-3658422e218c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-aec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78d1c0bc-006c-42f7-b40c-35d1a4b90ac3", "AQAAAAEAACcQAAAAEJH/OyTZIYAxRQJBgOVblb+25KPBsAXTmWt1zZ50tuR5dDkGJ51lR6Ri/V1nzmaXKw==", "5cce9d62-e1b6-4ce7-a1b9-e841839f18ee" });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Suburb_SuburbID",
                table: "AspNetUsers",
                column: "SuburbID",
                principalTable: "Suburb",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Suburb_SuburbID",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "SuburbID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IDNumber",
                table: "AspNetUsers",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(13)",
                oldMaxLength: 13,
                oldNullable: true);

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f62ffe09-8b9a-4d35-a9a2-31c6d41995ec", "AQAAAAEAACcQAAAAEH8f6yGWJkS4Z8bBgNc6pT6cn4/E7aIWMYoqooq1gGqqnunftCwVWRs2DUUAkjEOSQ==", "5a24785a-f831-4d3e-aeb8-427210038903" });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Suburb_SuburbID",
                table: "AspNetUsers",
                column: "SuburbID",
                principalTable: "Suburb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
