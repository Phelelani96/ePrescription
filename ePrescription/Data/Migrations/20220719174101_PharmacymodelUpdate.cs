using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ePrescription.Data.Migrations
{
    public partial class PharmacymodelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pharmacy_AspNetUsers_PharmacistId",
                table: "Pharmacy");

            migrationBuilder.DropIndex(
                name: "IX_Pharmacy_PharmacistId",
                table: "Pharmacy");

            migrationBuilder.AlterColumn<string>(
                name: "PracticeNo",
                table: "Practice",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNo",
                table: "Practice",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PharmacistId",
                table: "Pharmacy",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pharmacy_AspNetUsers_PharmacistId",
                table: "Pharmacy");

            migrationBuilder.DropIndex(
                name: "IX_Pharmacy_PharmacistId",
                table: "Pharmacy");

            migrationBuilder.AlterColumn<string>(
                name: "PracticeNo",
                table: "Practice",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNo",
                table: "Practice",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "PharmacistId",
                table: "Pharmacy",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-aec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30f930f7-54cb-4bbd-bef3-8451ea9e0fb2", "AQAAAAEAACcQAAAAEMB4RoTvY1vR6VUeLHQYWGa/RDk924TU+zg6DhIOtKlvc7cnDNIqFlLKw8GaRWU+Fw==", "dd118e67-319d-4236-bac9-db9af06b4aba" });

            migrationBuilder.CreateIndex(
                name: "IX_Pharmacy_PharmacistId",
                table: "Pharmacy",
                column: "PharmacistId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pharmacy_AspNetUsers_PharmacistId",
                table: "Pharmacy",
                column: "PharmacistId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
