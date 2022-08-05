using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ePrescription.Data.Migrations
{
    public partial class MedicineRefactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicine_Size_SizeId",
                table: "Medicine");

            migrationBuilder.DropColumn(
                name: "DosageFormId",
                table: "Medicine");

            migrationBuilder.RenameColumn(
                name: "SizeId",
                table: "Medicine",
                newName: "MedSizeId");

            migrationBuilder.RenameIndex(
                name: "IX_Medicine_SizeId",
                table: "Medicine",
                newName: "IX_Medicine_MedSizeId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Medicine_Size_MedSizeId",
                table: "Medicine",
                column: "MedSizeId",
                principalTable: "Size",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicine_Size_MedSizeId",
                table: "Medicine");

            migrationBuilder.RenameColumn(
                name: "MedSizeId",
                table: "Medicine",
                newName: "SizeId");

            migrationBuilder.RenameIndex(
                name: "IX_Medicine_MedSizeId",
                table: "Medicine",
                newName: "IX_Medicine_SizeId");

            migrationBuilder.AddColumn<int>(
                name: "DosageFormId",
                table: "Medicine",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "3d1f4f3c-b0be-4916-a016-3998817a111f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "9b7e7604-fb4f-471c-8e73-d37c60873ae7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "a999a052-2964-41b0-80d7-4be9ce676a47");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "cf80b0d5-be81-4dac-9361-7b94d88b9939");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-aec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7adf0d5b-f9ca-4ae3-9763-0b5aa07c5464", "AQAAAAEAACcQAAAAEGCs9fcRZ3fB9e7hkFrKAopUEqwzXMVx6jn/SV4yl+GxNf6t+zPcMhQThG3ToG7/4Q==", "22aacdad-1bc7-427c-899d-9b0773a6cc3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-ccc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dae94cc8-ed9a-4df1-997c-febbdb1bda72", "AQAAAAEAACcQAAAAEPD23rr0Dbw7u2RVJjql0+Rr0BMn0Zb8HPL9yPdD09MsyuEzAHjtAzHxEZSfJK/mhA==", "7d675790-3159-44df-83d3-f6dc8268395e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-eee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8939e618-a15d-47a8-b8fe-d348a5d48347", "AQAAAAEAACcQAAAAEIwqlQX2cWCqEaPvsoHvoBsPUz9cL2GVOv8TL05Qz8WWAxRjuJ18P21CZzyqTcvD4g==", "a2426180-c2cf-4688-a7bb-df6651ae0d85" });

            migrationBuilder.AddForeignKey(
                name: "FK_Medicine_Size_SizeId",
                table: "Medicine",
                column: "SizeId",
                principalTable: "Size",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
