using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ePrescription.Data.Migrations
{
    public partial class PharmacyUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pharmacy_AspNetUsers_PharmacistId",
                table: "Pharmacy");

            migrationBuilder.DropIndex(
                name: "IX_Pharmacy_PharmacistId",
                table: "Pharmacy");

            migrationBuilder.DropColumn(
                name: "PharmacistId",
                table: "Pharmacy");

            migrationBuilder.AddColumn<int>(
                name: "PharmacyId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "3908fc6d-e7d6-4e3c-bcf9-b2d40d131c3f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "b209ad44-5faf-417b-979c-2d2194a8ab54");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "dadb99f4-13af-4798-b20a-d30c18bb3347");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "c536ad55-c0d4-45c4-b6d2-4ff8f764bb7a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-aec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff825ec8-890d-4bdc-820c-8252b5d27aa1", "AQAAAAEAACcQAAAAEK3BB3o503Nnwikci/pf38W1YXMsPIXq8VCZ4YyddozuDP6p8JqvedrsD6/caG6vmQ==", "a5cba8b1-1630-4beb-9281-88481fe901a9" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PharmacyId",
                table: "AspNetUsers",
                column: "PharmacyId",
                unique: true,
                filter: "[PharmacyId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Pharmacy_PharmacyId",
                table: "AspNetUsers",
                column: "PharmacyId",
                principalTable: "Pharmacy",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Pharmacy_PharmacyId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PharmacyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PharmacyId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "PharmacistId",
                table: "Pharmacy",
                type: "nvarchar(450)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Pharmacy_PharmacistId",
                table: "Pharmacy",
                column: "PharmacistId",
                unique: true,
                filter: "[PharmacistId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Pharmacy_AspNetUsers_PharmacistId",
                table: "Pharmacy",
                column: "PharmacistId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
