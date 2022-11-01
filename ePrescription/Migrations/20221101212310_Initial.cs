using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ePrescription.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diagnosis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ICD10_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnosis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dosage_Form",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dosage_Form", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
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
                name: "Qualification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualification", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
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
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Medicine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dosage_FormId = table.Column<int>(type: "int", nullable: false),
                    MedSizeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScheduleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medicine_Dosage_Form_Dosage_FormId",
                        column: x => x.Dosage_FormId,
                        principalTable: "Dosage_Form",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Medicine_Schedule_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Contra_Indications_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Contra_Indications_Severity_SeverityId",
                        column: x => x.SeverityId,
                        principalTable: "Severity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Med_Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    MedicineId = table.Column<int>(type: "int", nullable: false),
                    Strength = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Med_Ingredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Med_Ingredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Med_Ingredients_Medicine_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Pharmacy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicenceNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuburbID = table.Column<int>(type: "int", nullable: false),
                    PharmacistId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pharmacy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pharmacy_Suburb_SuburbID",
                        column: x => x.SuburbID,
                        principalTable: "Suburb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Practice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PracticeNo = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuburbID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Practice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Practice_Suburb_SuburbID",
                        column: x => x.SuburbID,
                        principalTable: "Suburb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuburbID = table.Column<int>(type: "int", nullable: false),
                    PharmacyId = table.Column<int>(type: "int", nullable: true),
                    PracticeId = table.Column<int>(type: "int", nullable: true),
                    QualificationId = table.Column<int>(type: "int", nullable: true),
                    RegistrationNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Pharmacy_PharmacyId",
                        column: x => x.PharmacyId,
                        principalTable: "Pharmacy",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Practice_PracticeId",
                        column: x => x.PracticeId,
                        principalTable: "Practice",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Qualification_QualificationId",
                        column: x => x.QualificationId,
                        principalTable: "Qualification",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Suburb_SuburbID",
                        column: x => x.SuburbID,
                        principalTable: "Suburb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medical_History",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DiagnosisId = table.Column<int>(type: "int", nullable: false),
                    DiagnosisDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Medical_HistoryId = table.Column<int>(type: "int", nullable: true),
                    MedicineId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medical_History", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medical_History_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Medical_History_Diagnosis_DiagnosisId",
                        column: x => x.DiagnosisId,
                        principalTable: "Diagnosis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Medical_History_Medical_History_Medical_HistoryId",
                        column: x => x.Medical_HistoryId,
                        principalTable: "Medical_History",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Medical_History_Medicine_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicine",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Patient_Allergies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    IngredientsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient_Allergies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patient_Allergies_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Patient_Allergies_Ingredients_IngredientsId",
                        column: x => x.IngredientsId,
                        principalTable: "Ingredients",
                        principalColumn: "Id");
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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_History_Medication_Medicine_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Prescription_Details_Medicine_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Prescription_Details_Prescription_PrescriptionId",
                        column: x => x.PrescriptionId,
                        principalTable: "Prescription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "8b490c10-7502-44fb-b6df-c772cc59863a", "Admin", "ADMIN" },
                    { "2", "ddebf2cb-3ec3-430c-8b30-c7346500f31b", "Doctor", "DOCTOR" },
                    { "3", "fb48519f-1f29-4f51-adcd-1ca0c59f0148", "Pharmacist", "PHARMACIST" },
                    { "4", "38c3cada-c706-46d4-adf7-b52e536ca28d", "Patient", "PATIENT" }
                });

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

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Western Cape" },
                    { 2, "North West" },
                    { 3, "Eastern Cape" },
                    { 4, "Gauteng" }
                });

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "Free State" },
                    { 6, "Limpopo" },
                    { 7, "Mpumalanga" },
                    { 8, "Northern Cape" },
                    { 9, "KwaZulu-Natal" }
                });

            migrationBuilder.InsertData(
                table: "Qualification",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Degree" },
                    { 2, "Masters" }
                });

            //migrationBuilder.InsertData(
            //    table: "AspNetUserRoles",
            //    columns: new[] { "RoleId", "UserId" },
            //    values: new object[] { "2", "abc-123-ABC-246-eee" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Name", "ProvinceId" },
                values: new object[,]
                {
                    { 1, "Gqeberha", 3 },
                    { 2, "Johannesburg", 4 },
                    { 3, "Bhisho", 3 },
                    { 4, "Polokwane", 6 },
                    { 5, "Bloemfontein", 5 },
                    { 6, "Mbombela", 7 },
                    { 7, "Mahikeng", 2 },
                    { 8, "Kimberley", 8 },
                    { 9, "Cape Town", 1 },
                    { 10, "Pietermarizburg", 9 },
                    { 11, "Durban", 9 }
                });

            migrationBuilder.InsertData(
                table: "Suburb",
                columns: new[] { "Id", "CityId", "Name", "PostalCode" },
                values: new object[,]
                {
                    { 1, 7, "Kamagugu", "1200" },
                    { 2, 11, "Essenwood", "4001" },
                    { 3, 1, "Bridgemead", "6025" },
                    { 4, 11, "Kenville", "4051" },
                    { 5, 1, "Humewood", "6001" },
                    { 6, 11, "Cato Manor", "4091" },
                    { 7, 1, "Algoa Park", "6001" },
                    { 8, 11, "Musgrave", "4001" },
                    { 9, 6, "Barberton", "1300" },
                    { 10, 11, "Bluff", "4052" },
                    { 11, 1, "Cotswold", "6045" },
                    { 12, 11, "Glenmore", "4001" },
                    { 13, 6, "Riverside", "1226" },
                    { 14, 1, "Lorraine", "6070" },
                    { 15, 11, "Kwamashu", "4359" },
                    { 16, 11, "Inanda", "4309" },
                    { 17, 1, "Struandale", "6001" },
                    { 18, 6, "Valencia Park", "1201" },
                    { 19, 11, "Tongaat", "4399" },
                    { 20, 11, "Greyville", "4001" },
                    { 21, 1, "Malabar", "6020" },
                    { 22, 1, "Summerstrand", "6001" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IDNumber", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PharmacyId", "PhoneNumber", "PhoneNumberConfirmed", "PracticeId", "QualificationId", "RegistrationNo", "SecurityStamp", "SuburbID", "TwoFactorEnabled", "UserName" },
                values: new object[] { "abc-123-ABC-246-aec", 0, "14 8th Avenue", null, "70a7c7f1-edef-4acb-b827-fe24cf93cd82", "Admin", "tonystark@gmail.com", true, "Tony", "8611262654879", "Stark", false, null, "TONYSTARK@GMAIL.COM", "TONYSTARK@GMAIL.COM", "AQAAAAEAACcQAAAAEDGxZrsdA4sMEjlGpRNQ+D13H8kmMFI5SL02kO/LB6xI/GJ4DqkD/uiDo2LItdbJaA==", null, "0780509071", true, null, null, null, "35097686-6740-44b4-97cf-6b7f20cdefcc", 1, false, "tonystark@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "abc-123-ABC-246-aec" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PharmacyId",
                table: "AspNetUsers",
                column: "PharmacyId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PracticeId",
                table: "AspNetUsers",
                column: "PracticeId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_QualificationId",
                table: "AspNetUsers",
                column: "QualificationId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SuburbID",
                table: "AspNetUsers",
                column: "SuburbID");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                name: "IX_Med_Ingredients_IngredientId",
                table: "Med_Ingredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_Med_Ingredients_MedicineId",
                table: "Med_Ingredients",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_Medical_History_DiagnosisId",
                table: "Medical_History",
                column: "DiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_Medical_History_Medical_HistoryId",
                table: "Medical_History",
                column: "Medical_HistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Medical_History_MedicineId",
                table: "Medical_History",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_Medical_History_PatientId",
                table: "Medical_History",
                column: "PatientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medicine_Dosage_FormId",
                table: "Medicine",
                column: "Dosage_FormId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicine_ScheduleId",
                table: "Medicine",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Allergies_IngredientsId",
                table: "Patient_Allergies",
                column: "IngredientsId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Allergies_PatientId",
                table: "Patient_Allergies",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Pharmacy_SuburbID",
                table: "Pharmacy",
                column: "SuburbID");

            migrationBuilder.CreateIndex(
                name: "IX_Practice_SuburbID",
                table: "Practice",
                column: "SuburbID");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Contra_Indications");

            migrationBuilder.DropTable(
                name: "History_Medication");

            migrationBuilder.DropTable(
                name: "Med_Ingredients");

            migrationBuilder.DropTable(
                name: "Patient_Allergies");

            migrationBuilder.DropTable(
                name: "Prescription_Details");

            migrationBuilder.DropTable(
                name: "Size");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Severity");

            migrationBuilder.DropTable(
                name: "Medical_History");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Prescription");

            migrationBuilder.DropTable(
                name: "Diagnosis");

            migrationBuilder.DropTable(
                name: "Medicine");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Dosage_Form");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropTable(
                name: "Pharmacy");

            migrationBuilder.DropTable(
                name: "Practice");

            migrationBuilder.DropTable(
                name: "Qualification");

            migrationBuilder.DropTable(
                name: "Suburb");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Province");
        }
    }
}
