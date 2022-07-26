using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ePrescription.Data.Migrations
{
    public partial class MoreModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Allergy_AspNetUsers_PatientId",
                table: "Patient_Allergy");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Allergy_Ingredients_IngredientsId",
                table: "Patient_Allergy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patient_Allergy",
                table: "Patient_Allergy");

            migrationBuilder.RenameTable(
                name: "Patient_Allergy",
                newName: "Patient_Allergies");

            migrationBuilder.RenameIndex(
                name: "IX_Patient_Allergy_PatientId",
                table: "Patient_Allergies",
                newName: "IX_Patient_Allergies_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_Patient_Allergy_IngredientsId",
                table: "Patient_Allergies",
                newName: "IX_Patient_Allergies_IngredientsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patient_Allergies",
                table: "Patient_Allergies",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "History_Medication",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Medical_HistoryId = table.Column<int>(type: "int", nullable: false),
                    MedicineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History_Medication", x => x.Id);
                    table.ForeignKey(
                        name: "FK_History_Medication_Medical_History_Medical_HistoryId",
                        column: x => x.Medical_HistoryId,
                        principalTable: "Medical_History",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_History_Medication_Medicine_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prescription",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DoctorId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prescription_AspNetUsers_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Prescription_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Severity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Severity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prescription_Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicineId = table.Column<int>(type: "int", nullable: false),
                    PrescriptionId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Repetition = table.Column<int>(type: "int", nullable: false),
                    PharmacistId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Instructions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescription_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prescription_Details_AspNetUsers_PharmacistId",
                        column: x => x.PharmacistId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prescription_Details_Medicine_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prescription_Details_Prescription_PrescriptionId",
                        column: x => x.PrescriptionId,
                        principalTable: "Prescription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvinceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_Province_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Province",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contra_Indications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiagnosisId = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    SeverityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contra_Indications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contra_Indications_Diagnosis_DiagnosisId",
                        column: x => x.DiagnosisId,
                        principalTable: "Diagnosis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contra_Indications_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contra_Indications_Severity_SeverityId",
                        column: x => x.SeverityId,
                        principalTable: "Severity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Suburb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suburb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suburb_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Practice_SuburbID",
                table: "Practice",
                column: "SuburbID");

            migrationBuilder.CreateIndex(
                name: "IX_Pharmacy_SuburbID",
                table: "Pharmacy",
                column: "SuburbID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SuburbID",
                table: "AspNetUsers",
                column: "SuburbID");

            migrationBuilder.CreateIndex(
                name: "IX_City_ProvinceId",
                table: "City",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Contra_Indications_DiagnosisId",
                table: "Contra_Indications",
                column: "DiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_Contra_Indications_IngredientId",
                table: "Contra_Indications",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_Contra_Indications_SeverityId",
                table: "Contra_Indications",
                column: "SeverityId");

            migrationBuilder.CreateIndex(
                name: "IX_History_Medication_Medical_HistoryId",
                table: "History_Medication",
                column: "Medical_HistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_History_Medication_MedicineId",
                table: "History_Medication",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_DoctorId",
                table: "Prescription",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_PatientId",
                table: "Prescription",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_Details_MedicineId",
                table: "Prescription_Details",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_Details_PharmacistId",
                table: "Prescription_Details",
                column: "PharmacistId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_Details_PrescriptionId",
                table: "Prescription_Details",
                column: "PrescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Suburb_CityId",
                table: "Suburb",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Suburb_SuburbID",
                table: "AspNetUsers",
                column: "SuburbID",
                principalTable: "Suburb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Allergies_AspNetUsers_PatientId",
                table: "Patient_Allergies",
                column: "PatientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Allergies_Ingredients_IngredientsId",
                table: "Patient_Allergies",
                column: "IngredientsId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pharmacy_Suburb_SuburbID",
                table: "Pharmacy",
                column: "SuburbID",
                principalTable: "Suburb",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Practice_Suburb_SuburbID",
                table: "Practice",
                column: "SuburbID",
                principalTable: "Suburb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Suburb_SuburbID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Allergies_AspNetUsers_PatientId",
                table: "Patient_Allergies");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Allergies_Ingredients_IngredientsId",
                table: "Patient_Allergies");

            migrationBuilder.DropForeignKey(
                name: "FK_Pharmacy_Suburb_SuburbID",
                table: "Pharmacy");

            migrationBuilder.DropForeignKey(
                name: "FK_Practice_Suburb_SuburbID",
                table: "Practice");

            migrationBuilder.DropTable(
                name: "Contra_Indications");

            migrationBuilder.DropTable(
                name: "History_Medication");

            migrationBuilder.DropTable(
                name: "Prescription_Details");

            migrationBuilder.DropTable(
                name: "Suburb");

            migrationBuilder.DropTable(
                name: "Severity");

            migrationBuilder.DropTable(
                name: "Prescription");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.DropIndex(
                name: "IX_Practice_SuburbID",
                table: "Practice");

            migrationBuilder.DropIndex(
                name: "IX_Pharmacy_SuburbID",
                table: "Pharmacy");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SuburbID",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patient_Allergies",
                table: "Patient_Allergies");

            migrationBuilder.RenameTable(
                name: "Patient_Allergies",
                newName: "Patient_Allergy");

            migrationBuilder.RenameIndex(
                name: "IX_Patient_Allergies_PatientId",
                table: "Patient_Allergy",
                newName: "IX_Patient_Allergy_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_Patient_Allergies_IngredientsId",
                table: "Patient_Allergy",
                newName: "IX_Patient_Allergy_IngredientsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patient_Allergy",
                table: "Patient_Allergy",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Allergy_AspNetUsers_PatientId",
                table: "Patient_Allergy",
                column: "PatientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Allergy_Ingredients_IngredientsId",
                table: "Patient_Allergy",
                column: "IngredientsId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
