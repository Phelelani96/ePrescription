using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ePrescription.Data.Migrations
{
    public partial class seedingSuburbs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Eastern Cape" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Name", "ProvinceId" },
                values: new object[] { 1, "Gqeberha", 1 });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Name", "ProvinceId" },
                values: new object[] { 2, "East London", 1 });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Name", "ProvinceId" },
                values: new object[] { 3, "Makhanda", 1 });

            migrationBuilder.InsertData(
                table: "Suburb",
                columns: new[] { "Id", "CityId", "Name", "PostalCode" },
                values: new object[] { 1, 1, "Summerstrand", "6001" });

            migrationBuilder.InsertData(
                table: "Suburb",
                columns: new[] { "Id", "CityId", "Name", "PostalCode" },
                values: new object[] { 2, 1, "Humewood", "6002" });

            migrationBuilder.InsertData(
                table: "Suburb",
                columns: new[] { "Id", "CityId", "Name", "PostalCode" },
                values: new object[] { 3, 1, "Walmer", "6003" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Suburb",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suburb",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Suburb",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
