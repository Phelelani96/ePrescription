using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ePrescription.Data.Migrations
{
    public partial class MedicineRefactors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ScheduledId",
                table: "Medicine");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "a37d3798-eb85-44c0-9e8e-8e1a2b9bb5e7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "42551a2b-f174-4202-bf62-e72f6882413a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "0b28f072-9040-44d7-bf75-0ce6a29df154");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "681bc315-9cbf-4ac4-a9cd-d73c9b4998d0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-aec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42693a4a-9d51-4d75-9262-5baf5839bc78", "AQAAAAEAACcQAAAAEOa1NgrWoy6X0oetREnzzW7Iw08OYQjZJ4UG7+/C7oLRheOXn0+T3dpVH8bbSqpqJA==", "279c9b5b-5134-4e7e-8128-3ba780730d4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-ccc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7757a44-55bb-4ea6-9a4a-4160acf85cf7", "AQAAAAEAACcQAAAAEIOtAaIsStaXp6InvLsQdqJXUvY9AEy0a8GNAVejRZUrCwpyVFWI1Z+OGQSgueN53Q==", "35f904b5-3736-4145-9fab-0da3ef243d60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-eee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30f6d275-a660-4e43-bbac-d8be8379e17a", "AQAAAAEAACcQAAAAEAn/9qy3Z/RUfcZ5uMvQR07O6Ac/ki+8ZhDrJfGxgMszfG9NOhkR852DSBnOGiSojQ==", "fd0396db-e85c-4e4e-9c7f-bb8391dcef64" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ScheduledId",
                table: "Medicine",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "c55f0158-44ef-4fc6-8a31-cfd3584056e1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "8ec3f5f2-4bec-4d3d-ac3c-3dd05cff8942");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "49e36338-da75-4d04-95a6-c1bf7a34cd7a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "13c4a3f1-863c-4490-bc21-ba9da8f2d011");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-aec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fdd7956-b974-4ca9-9f9b-eb83d8ab7c77", "AQAAAAEAACcQAAAAEBjXrKtBER0GKQ7thVCQdHj09384hWFcan3gFhFrlmmih7myvCxoFM5tJ/wNscp4Ag==", "03d42390-130d-4498-8f6c-1bc003e4037d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-ccc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c990c850-935b-43f1-86c0-0d9318ae592c", "AQAAAAEAACcQAAAAELe/bke8eyvy6/SoIyRrgZli7AqtH6RPXJShaWO4VEq4fAvzHqC0ys86Sf9Anny6IA==", "5fc571ea-efa4-44c6-9dff-f2c491351510" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-eee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe78f9f3-0af3-432c-b870-3bdbe00132b4", "AQAAAAEAACcQAAAAEK9ajUeB1rNJ+Q5aHTQrGa8Az8yyaunbxpGaba5BvZ36P6mKl8DfpXlHOpoBoo/mMQ==", "ca3fadf2-4338-46a3-b874-4be6c11d33d8" });
        }
    }
}
