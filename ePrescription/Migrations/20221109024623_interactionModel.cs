using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ePrescription.Migrations
{
    public partial class interactionModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interactions_Medicine_Medicine1Id",
                table: "Interactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Interactions_Medicine_Medicine2Id",
                table: "Interactions");

            migrationBuilder.RenameColumn(
                name: "Medicine2Id",
                table: "Interactions",
                newName: "Ingredient2Id");

            migrationBuilder.RenameColumn(
                name: "Medicine1Id",
                table: "Interactions",
                newName: "Ingredient1Id");

            migrationBuilder.RenameIndex(
                name: "IX_Interactions_Medicine2Id",
                table: "Interactions",
                newName: "IX_Interactions_Ingredient2Id");

            migrationBuilder.RenameIndex(
                name: "IX_Interactions_Medicine1Id",
                table: "Interactions",
                newName: "IX_Interactions_Ingredient1Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "299d73c5-f200-4f6e-b122-19e3439be365");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "fca343a8-8e4b-424b-94d7-6ce721679013");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "82a1dd3f-3312-47bd-b9dd-545d50ddbd68");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "bb219bd2-e0c4-4254-b73f-f9994dee9dce");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-aec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f16a640-b662-423f-abae-d62e7e844f15", "AQAAAAEAACcQAAAAEKBirJSKY6hB6qbljyXqQvlPD5sbOsMtPUX4rhooe8Vh8Y7WfJHLvd0IO2llshkx+w==", "7905ac3f-22ac-49f7-a695-411873ffc5bc" });

            migrationBuilder.AddForeignKey(
                name: "FK_Interactions_Ingredients_Ingredient1Id",
                table: "Interactions",
                column: "Ingredient1Id",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Interactions_Ingredients_Ingredient2Id",
                table: "Interactions",
                column: "Ingredient2Id",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interactions_Ingredients_Ingredient1Id",
                table: "Interactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Interactions_Ingredients_Ingredient2Id",
                table: "Interactions");

            migrationBuilder.RenameColumn(
                name: "Ingredient2Id",
                table: "Interactions",
                newName: "Medicine2Id");

            migrationBuilder.RenameColumn(
                name: "Ingredient1Id",
                table: "Interactions",
                newName: "Medicine1Id");

            migrationBuilder.RenameIndex(
                name: "IX_Interactions_Ingredient2Id",
                table: "Interactions",
                newName: "IX_Interactions_Medicine2Id");

            migrationBuilder.RenameIndex(
                name: "IX_Interactions_Ingredient1Id",
                table: "Interactions",
                newName: "IX_Interactions_Medicine1Id");

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
                name: "FK_Interactions_Medicine_Medicine1Id",
                table: "Interactions",
                column: "Medicine1Id",
                principalTable: "Medicine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Interactions_Medicine_Medicine2Id",
                table: "Interactions",
                column: "Medicine2Id",
                principalTable: "Medicine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
