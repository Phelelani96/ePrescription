using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ePrescription.Data.Migrations
{
    public partial class SeedDummyDataP1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "73d2dbf9-02b5-40d1-be41-13eda0ad3fae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "06ad10ce-0792-4748-b667-06817b177f50");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "41f0b51b-f6e8-4236-be7f-5ef81046891f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "55b878e2-6bcd-4b7f-9ade-999c6e722f53");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-aec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b4fd118-f0e5-408b-b727-943bbbf1092b", "AQAAAAEAACcQAAAAELgXOYi6BoFz/NL9CaD+xV+IF7QhUrdnCrtk/CuNhe7qmJ2t+sRBGH1U1xE+ziBMIQ==", "6c6e50ec-8325-4f7d-a619-bd2bf7399a73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-ccc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d05c8e4-d936-482f-962b-c10150e52fe6", "AQAAAAEAACcQAAAAEC1L2wFxfkeFyQrLlC2cuhxaSih5LYssQ+0xs2CutYElJitenvKJZjStA39VvkxZow==", "d1f0188c-a14f-4cee-94e7-6d501def8bcf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-eee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a957d66-9edd-42d0-a90f-996f12adac13", "AQAAAAEAACcQAAAAEBAlPtPVWJLgZxdgXwcvM2HoNncY4Xmcp0XRxpVcLA44W5ndU01JMYYAC98x47+JLA==", "ef11ca8d-79f4-4970-a1f9-d8a3b6fdb5ad" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Name", "ProvinceId" },
                values: new object[] { 9, "Cape Town", 1 });

            migrationBuilder.InsertData(
                table: "Diagnosis",
                columns: new[] { "Id", "Description", "ICD10_Code" },
                values: new object[,]
                {
                    { 1, "Attention Deficit Disorder", "F90.9" },
                    { 2, "Hyperthyroidism", "E05.9" },
                    { 3, "Migraine", "G43.909" },
                    { 4, "Back Pain", "M54.9" },
                    { 5, "Hypertension", "I10.9" },
                    { 6, "Asthma ", "J45.909" },
                    { 7, "High Cholesterol", "E78.5" }
                });

            migrationBuilder.InsertData(
                table: "Dosage_Form",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Tablet" },
                    { 2, "Capsule" },
                    { 3, "Suspension" },
                    { 4, "Syrup" },
                    { 5, "Lotion" },
                    { 6, "Spray" },
                    { 7, "Gel" },
                    { 8, "Suppository" },
                    { 9, "Injection" },
                    { 10, "Drops" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Methylphenidate HCI " },
                    { 2, "Ergotamine tartare" },
                    { 3, "Cyclizine HCI" },
                    { 4, "Caffeine Hydrate" },
                    { 5, "Paracetamol" },
                    { 6, "Codeine Phosphate" },
                    { 7, "Caffeine" },
                    { 8, "Doxylamine Succinate" },
                    { 9, "Aspirin" },
                    { 10, "Ibuprofen" },
                    { 11, "Phenazone" },
                    { 12, "Benzocaine" },
                    { 13, "Glycerine" },
                    { 14, "Carbimazole" },
                    { 15, "Metoprolol Tartrate " },
                    { 16, "Doxazosin" },
                    { 17, "Atorvastatin" }
                });

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Western Cape");

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "North West" },
                    { 3, "Eastern Cape" },
                    { 4, "Gauteng" },
                    { 5, "Free State" },
                    { 6, "Limpopo" },
                    { 7, "Mpumalanga" },
                    { 8, "Northern Cape" },
                    { 9, "KwaZulu-Natal" }
                });

            migrationBuilder.UpdateData(
                table: "Suburb",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "PostalCode" },
                values: new object[] { "Bridgemead", "6025" });

            migrationBuilder.InsertData(
                table: "Suburb",
                columns: new[] { "Id", "CityId", "Name", "PostalCode" },
                values: new object[,]
                {
                    { 5, 1, "Humewood", "6001" },
                    { 7, 1, "Algoa Park", "6001" },
                    { 11, 1, "Cotswold", "6045" },
                    { 14, 1, "Lorraine", "6070" },
                    { 17, 1, "Struandale", "6001" },
                    { 21, 1, "Malabar", "6020" },
                    { 22, 1, "Summerstrand", "6001" }
                });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProvinceId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "ProvinceId" },
                values: new object[] { "Johannesburg", 4 });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "ProvinceId" },
                values: new object[] { "Bhisho", 3 });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Name", "ProvinceId" },
                values: new object[,]
                {
                    { 4, "Polokwane", 6 },
                    { 5, "Bloemfontein", 5 },
                    { 6, "Mbombela", 7 },
                    { 7, "Mahikeng", 2 },
                    { 8, "Kimberley", 8 },
                    { 10, "Pietermarizburg", 9 },
                    { 11, "Durban", 9 }
                });

            migrationBuilder.UpdateData(
                table: "Suburb",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CityId", "Name", "PostalCode" },
                values: new object[] { 7, "Kamagugu", "1200" });

            migrationBuilder.UpdateData(
                table: "Suburb",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CityId", "Name", "PostalCode" },
                values: new object[] { 11, "Essenwood", "4001" });

            migrationBuilder.InsertData(
                table: "Suburb",
                columns: new[] { "Id", "CityId", "Name", "PostalCode" },
                values: new object[,]
                {
                    { 4, 11, "Kenville", "4051" },
                    { 6, 11, "Cato Manor", "4091" },
                    { 8, 11, "Musgrave", "4001" },
                    { 9, 6, "Barberton", "1300" },
                    { 10, 11, "Bluff", "4052" },
                    { 12, 11, "Glenmore", "4001" },
                    { 13, 6, "Riverside", "1226" },
                    { 15, 11, "Kwamashu", "4359" },
                    { 16, 11, "Inanda", "4309" },
                    { 18, 6, "Valencia Park", "1201" },
                    { 19, 11, "Tongaat", "4399" },
                    { 20, 11, "Greyville", "4001" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dosage_Form",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dosage_Form",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dosage_Form",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dosage_Form",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dosage_Form",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dosage_Form",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dosage_Form",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dosage_Form",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Dosage_Form",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Dosage_Form",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Suburb",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Suburb",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Suburb",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Suburb",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Suburb",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Suburb",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Suburb",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Suburb",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Suburb",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Suburb",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Suburb",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Suburb",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Suburb",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Suburb",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Suburb",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Suburb",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Suburb",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Suburb",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Suburb",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 9);

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

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProvinceId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "ProvinceId" },
                values: new object[] { "East London", 1 });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "ProvinceId" },
                values: new object[] { "Makhanda", 1 });

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Eastern Cape");

            migrationBuilder.UpdateData(
                table: "Suburb",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CityId", "Name", "PostalCode" },
                values: new object[] { 1, "Summerstrand", "6001" });

            migrationBuilder.UpdateData(
                table: "Suburb",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CityId", "Name", "PostalCode" },
                values: new object[] { 1, "Humewood", "6002" });

            migrationBuilder.UpdateData(
                table: "Suburb",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "PostalCode" },
                values: new object[] { "Walmer", "6003" });
        }
    }
}
