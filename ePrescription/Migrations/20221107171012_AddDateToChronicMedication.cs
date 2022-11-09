using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ePrescription.Migrations
{
    public partial class AddDateToChronicMedication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "History_Medication",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "7dbf75da-e050-4a3e-bf6a-805920668a6b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "8b562536-2ca5-447a-975c-7cc0cd2f8724");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "add29d8e-c713-4bfb-b72f-8eccdfb286dc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "6e3f67d4-59dc-402c-a4a0-717a27997315");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-aec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61433787-cefd-43e6-9ffb-608a327cf2e0", "AQAAAAEAACcQAAAAEJ7xw2wAFus4cWmFnVa1XHb7/s3fy6rZyNXxDq1+DMgjKaQogNmW9kD5flHq9cbXDg==", "294cfa35-51ec-402a-9309-57b7aa2511ef" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "History_Medication");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "c359cd01-64d4-467f-a4c6-abbe124710f4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "1f52fb91-0392-4874-8f1b-acb9b691aa26");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "f839b457-3417-4eef-9b13-e31a641cd56d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "be1f5163-7126-433c-abcf-b76f7da768a7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-aec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2767fccc-d1fb-455d-a59f-e273df6067f1", "AQAAAAEAACcQAAAAEJn2EIx43VF5tEc4BOITXrpAJkc4bEElDEBHBa5G5t9Vyp69NfANfha9UXuW0TG2Gg==", "6d028643-b335-4517-a38b-bce62b658769" });
        }
    }
}
