using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ePrescription.Data.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IDNumber", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PharmacyId", "PhoneNumber", "PhoneNumberConfirmed", "PracticeId", "QualificationId", "RegistrationNo", "SecurityStamp", "SuburbID", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "abc-123-ABC-246-ccc", 0, "8th Avenue", null, "9f3b7b24-9eec-4185-86cf-fe6508193691", "Pharmacist", "parker@gmail.com", true, "Peter", "9911262654123", "Parker", false, null, "PARKER@GMAIL.COM", "PARKER@GMAIL.COM", "AQAAAAEAACcQAAAAEMjRSQGwLKtNzTFtTASd8vDj0UxfHQOCeqvhLzYY50GOEXUHZ4jTRd01V+/W7IMImA==", 2, "0780509071", true, null, null, null, "4d703ba4-34b0-42a0-82f7-8185f7b3a781", 3, false, "parker@gmail.com" },
                    { "abc-123-ABC-246-eee", 0, "1 2th Avenue", null, "2dcd3cce-100c-45b6-839c-702bc6058fe8", "Doctor", "strange@gmail.com", true, "Doctor", "8611223659874", "Strange", false, null, "STRANGE@GMAIL.COM", "STRANGE@GMAIL.COM", "AQAAAAEAACcQAAAAEHuY3LC08afPlrhmrK8n2KLszbhdnHCMtv/0MOGpZE3lCcso6MOgRrViFH75OI8JjQ==", null, "0780509025", true, 3, 1, "123456789", "2fe66bd1-48db-4d7d-9493-8ed046a3e75d", 1, false, "strange@gmail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-ccc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-eee");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "24eff15c-7a5e-482a-9ae5-a3bd9e0213cf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "b46034ee-9757-4f41-b07b-81c201c6bebc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "cb08b710-fa0d-4b8a-82cd-e0f68ffa4132");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "393e21c7-8ffe-4776-ba6a-995196e56d67");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc-123-ABC-246-aec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51f365a3-381f-478b-8c39-d42f732365ec", "AQAAAAEAACcQAAAAEPcCHj3bw1sl8d0O0pgwCFit3NxFiugn5qYJabvyafMyFhv31UIfuzqj/ejKHAQZCg==", "4bb1ce84-f680-4522-9988-d0685bcb88b7" });
        }
    }
}
