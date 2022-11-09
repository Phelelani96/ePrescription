using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ePrescription.Migrations
{
    public partial class AddRepetitionsLeft : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medical_History_Medical_History_Medical_HistoryId",
                table: "Medical_History");

            migrationBuilder.DropIndex(
                name: "IX_Medical_History_Medical_HistoryId",
                table: "Medical_History");

            migrationBuilder.DropColumn(
                name: "Medical_HistoryId",
                table: "Medical_History");

            migrationBuilder.AddColumn<int>(
                name: "RepetitionLeft",
                table: "Prescription_Details",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "18bd4fea-4f6c-4aeb-a1b6-c3fef6f3e20e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "aeca2e40-6a56-4adb-958e-69df6d30000a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "e7d4c14e-f8b1-4d31-802e-b2b40570fcad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "d34735d5-0895-4b88-ab9e-07da8ccf978d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-aec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77344e7b-186b-46f1-9bba-0a316987adb5", "AQAAAAEAACcQAAAAEKJBaOVGqS5OhmJq5HNEJJTMa80S9FoL1KZ71yjDeUS8PrmwfFbhv4npPmlWbvwlkQ==", "fa473160-b38c-4d15-bf69-1f4ae2866246" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RepetitionLeft",
                table: "Prescription_Details");

            migrationBuilder.AddColumn<int>(
                name: "Medical_HistoryId",
                table: "Medical_History",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Medical_History_Medical_HistoryId",
                table: "Medical_History",
                column: "Medical_HistoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medical_History_Medical_History_Medical_HistoryId",
                table: "Medical_History",
                column: "Medical_HistoryId",
                principalTable: "Medical_History",
                principalColumn: "Id");
        }
    }
}
