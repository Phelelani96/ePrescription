using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ePrescription.Data.Migrations
{
    public partial class AddSizeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SizeId",
                table: "Medicine",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Medicine_SizeId",
                table: "Medicine",
                column: "SizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicine_Size_SizeId",
                table: "Medicine",
                column: "SizeId",
                principalTable: "Size",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicine_Size_SizeId",
                table: "Medicine");

            migrationBuilder.DropTable(
                name: "Size");

            migrationBuilder.DropIndex(
                name: "IX_Medicine_SizeId",
                table: "Medicine");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "Medicine");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "45ccfb16-6181-4968-bab6-0774d549a196");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "50a714ea-1697-4424-8efa-eaa86d5769ba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "a0181497-67a0-4cc1-887a-f87f16c2d0bf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "f3d981d5-50f1-4a78-ad95-715c0ca690f5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-aec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5d072ce-3e82-4ec9-b996-9f3e7f1100c4", "AQAAAAEAACcQAAAAEAIemUbQp3S4caLzZlEzE2eIycOK2Kbl7th189qBGaIS1fRcjr7iylZQl+VZT0rlfQ==", "13d447e6-64b2-43ca-a55f-11a9872d5164" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-ccc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f3b7b24-9eec-4185-86cf-fe6508193691", "AQAAAAEAACcQAAAAEMjRSQGwLKtNzTFtTASd8vDj0UxfHQOCeqvhLzYY50GOEXUHZ4jTRd01V+/W7IMImA==", "4d703ba4-34b0-42a0-82f7-8185f7b3a781" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-eee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2dcd3cce-100c-45b6-839c-702bc6058fe8", "AQAAAAEAACcQAAAAEHuY3LC08afPlrhmrK8n2KLszbhdnHCMtv/0MOGpZE3lCcso6MOgRrViFH75OI8JjQ==", "2fe66bd1-48db-4d7d-9493-8ed046a3e75d" });
        }
    }
}
