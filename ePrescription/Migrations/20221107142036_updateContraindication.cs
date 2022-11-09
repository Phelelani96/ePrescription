using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ePrescription.Migrations
{
    public partial class updateContraindication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contra_Indications_Severity_SeverityId",
                table: "Contra_Indications");

            migrationBuilder.DropIndex(
                name: "IX_Contra_Indications_SeverityId",
                table: "Contra_Indications");

            migrationBuilder.DropColumn(
                name: "SeverityId",
                table: "Contra_Indications");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SeverityId",
                table: "Contra_Indications",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                name: "IX_Contra_Indications_SeverityId",
                table: "Contra_Indications",
                column: "SeverityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contra_Indications_Severity_SeverityId",
                table: "Contra_Indications",
                column: "SeverityId",
                principalTable: "Severity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
