using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ePrescription.Migrations
{
    public partial class addInterctionModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Interactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Medicine1Id = table.Column<int>(type: "int", nullable: false),
                    Medicine2Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interactions_Medicine_Medicine1Id",
                        column: x => x.Medicine1Id,
                        principalTable: "Medicine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Interactions_Medicine_Medicine2Id",
                        column: x => x.Medicine2Id,
                        principalTable: "Medicine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ecc23572-dc2e-411d-8db6-d7b79fa09a92");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "4d7c4644-1a7a-4333-b9c9-ddca0ab64a30");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "45607338-193a-4ad3-88c6-6261eaac5307");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "1e8c6935-6f67-47d2-9179-622fcaf5b69d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-aec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c01c9118-a1c2-4991-a272-1071d7b882b1", "AQAAAAEAACcQAAAAEKQp1jk1xb+GFCDAlUwyHYOhjdfLotAVxu2HxYEIOQr0r7a6q0mOb9lMRbMV5+OSgA==", "e4048c5b-6b5e-4d89-9cce-8dce36ab8656" });

            migrationBuilder.CreateIndex(
                name: "IX_Interactions_Medicine1Id",
                table: "Interactions",
                column: "Medicine1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Interactions_Medicine2Id",
                table: "Interactions",
                column: "Medicine2Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Interactions");

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
        }
    }
}
