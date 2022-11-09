using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ePrescription.Migrations
{
    public partial class NullablePharmacist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Details_AspNetUsers_PharmacistId",
                table: "Prescription_Details");

            migrationBuilder.AlterColumn<string>(
                name: "PharmacistId",
                table: "Prescription_Details",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "9b467bd4-7ffb-4c7b-895e-f0165c2387ba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "44323bbf-5ce2-4f53-a32e-c658e05d4580");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "e3f86657-bc94-42c3-8e35-311eb63e4953");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "e09a5176-235b-43ef-bbd5-e5c94bc3bae0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-aec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02ce9237-87ac-47f9-843a-860da36e1b1f", "AQAAAAEAACcQAAAAELrWk7hXPGIZZVr5BMHJDf5z7FdvwTQvl3qCoSPhj3S0j/bcsH7sD8p1VN89ag42ng==", "612f0371-b946-47b4-9677-5853bc67d142" });

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Details_AspNetUsers_PharmacistId",
                table: "Prescription_Details",
                column: "PharmacistId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Details_AspNetUsers_PharmacistId",
                table: "Prescription_Details");

            migrationBuilder.AlterColumn<string>(
                name: "PharmacistId",
                table: "Prescription_Details",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Details_AspNetUsers_PharmacistId",
                table: "Prescription_Details",
                column: "PharmacistId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
