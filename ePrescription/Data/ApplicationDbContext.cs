using ePrescription.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ePrescription.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        private readonly SignInManager<User> _signInManager;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
           
            builder.Entity<Qualification>().HasData(
              new Qualification
              {
                  Id = 1,
                  Description = "Degree"
              },
              new Qualification
              {
                  Id = 2,
                  Description = "Masters"
              }
              );

            builder.Entity<User>().HasData(
                new User
                {
                    Id = "abc-123-ABC-246-aec",
                    FirstName = "Tony",
                    LastName = "Stark",
                    IDNumber = "8611262654879",
                    Email = "tonystark@gmail.com",
                    NormalizedEmail = "TONYSTARK@GMAIL.COM",
                    PhoneNumber = "0780509071",
                    UserName = "tonystark@gmail.com",
                    NormalizedUserName = "TONYSTARK@GMAIL.COM",
                    Discriminator = "Admin",
                    AddressLine1 = "14 8th Avenue",
                    SuburbID = 1,
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "Tony123!")

                });

            builder.Entity<Dosage_Form>().HasData(
                 new Dosage_Form
                 {
                     Id = 1,
                     Description = "Tablet"
                 },
                 new Dosage_Form
                 {
                     Id = 2,
                     Description = "Capsule"
                 },
                 new Dosage_Form
                 {
                     Id = 3,
                     Description = "Suspension"
                 },
                 new Dosage_Form
                 {
                     Id = 4,
                     Description = "Syrup"
                 },
                 new Dosage_Form
                 {
                     Id = 5,
                     Description = "Lotion"
                 },
                 new Dosage_Form
                 {
                     Id = 6,
                     Description = "Spray"
                 },
                 new Dosage_Form
                 {
                     Id = 7,
                     Description = "Gel"
                 },
                 new Dosage_Form
                 {
                     Id = 8,
                     Description = "Suppository"
                 },
                 new Dosage_Form
                 {
                     Id = 9,
                     Description = "Injection"
                 },
                 new Dosage_Form
                {
                    Id = 10,
                    Description = "Drops"
                });
               

            builder.Entity<Ingredients>().HasData(
                new Ingredients
                {
                    Id = 1,
                    Description = "Methylphenidate HCI "
                },
                new Ingredients
                {
                    Id = 2,
                    Description = "Ergotamine tartare"
                },
                new Ingredients
                {
                    Id = 3,
                    Description = "Cyclizine HCI"
                },
                new Ingredients
                {
                    Id = 4,
                    Description = "Caffeine Hydrate"
                },
                new Ingredients
                {
                    Id = 5,
                    Description = "Paracetamol"
                },
                new Ingredients
                {
                    Id = 6,
                    Description = "Codeine Phosphate"
                },
                new Ingredients
                {
                    Id = 7,
                    Description = "Caffeine"
                },
                new Ingredients
                {
                    Id = 8,
                    Description = "Doxylamine Succinate"
                },
                new Ingredients
                {
                    Id = 9,
                    Description = "Aspirin"
                },
                new Ingredients
                {
                    Id = 10,
                    Description = "Ibuprofen"
                },
                new Ingredients
                {
                    Id = 11,
                    Description = "Phenazone"
                },
                new Ingredients
                {
                    Id = 12,
                    Description = "Benzocaine"
                },
                new Ingredients
                {
                    Id = 13,
                    Description = "Glycerine"
                },
                new Ingredients
                {
                    Id = 14,
                    Description = "Carbimazole"
                },
                new Ingredients
                {
                    Id = 15,
                    Description = "Metoprolol Tartrate "
                },
                new Ingredients
                {
                    Id = 16,
                    Description = "Doxazosin"
                },
                new Ingredients
                {
                    Id = 17,
                    Description = "Atorvastatin"
                });

            
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1",
                    UserId = "abc-123-ABC-246-aec"
                },
                 new IdentityUserRole<string>
                 {
                     RoleId = "2",
                     UserId = "abc-123-ABC-246-eee"
                 }
                  //new IdentityUserRole<string>
                  //{
                  //    RoleId = "3",
                  //    UserId = "abc-123-ABC-246-ccc"
                  //}
                  );

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "1",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = "2",
                    Name = "Doctor",
                    NormalizedName = "DOCTOR"
                },
                new IdentityRole
                {
                    Id = "3",
                    Name = "Pharmacist",
                    NormalizedName = "PHARMACIST"
                },
                new IdentityRole
                {
                    Id = "4",
                    Name = "Patient",
                    NormalizedName = "PATIENT"
                });


            builder.Entity<Suburb>().HasData(
                new Suburb
                {
                    Id = 1,
                    Name = "Kamagugu",
                    CityId = 7,
                    PostalCode = "1200"
                },
                new Suburb
                 {
                     Id = 2,
                     Name = "Essenwood",
                     CityId = 11,
                     PostalCode = "4001"
                },
                new Suburb
                  {
                      Id = 3,
                      Name = "Bridgemead",
                      CityId = 1,
                      PostalCode = "6025"
                },
                new Suburb
                   {
                       Id = 4,
                       Name = "Kenville",
                       CityId = 11,
                       PostalCode = "4051"
                },
                new Suburb
                    {
                        Id = 5,
                        Name = "Humewood",
                        CityId = 1,
                        PostalCode = "6001"
                },
                new Suburb
                     {
                         Id = 6,
                         Name = "Cato Manor",
                         CityId = 11,
                         PostalCode = "4091"
                },
                new Suburb
                      {
                          Id = 7,
                          Name = "Algoa Park",
                          CityId = 1,
                          PostalCode = "6001"
                },
                new Suburb
                       {
                           Id = 8,
                           Name = "Musgrave",
                           CityId = 11,
                           PostalCode = "4001"
                },
                new Suburb
                        {
                            Id = 9,
                            Name = "Barberton",
                            CityId = 6,
                            PostalCode = "1300"
                },
                new Suburb
                         {
                             Id = 10,
                             Name = "Bluff",
                             CityId = 11,
                             PostalCode = "4052"
                },
                new Suburb
                          {
                              Id = 11,
                              Name = "Cotswold",
                              CityId = 1,
                              PostalCode = "6045"
                },
                new Suburb
                           {
                               Id = 12,
                               Name = "Glenmore",
                               CityId = 11,
                               PostalCode = "4001"
                },
                new Suburb
                            {
                                Id = 13,
                                Name = "Riverside",
                                CityId = 6,
                                PostalCode = "1226"
                },
                new Suburb
                             {
                                 Id = 14,
                                 Name = "Lorraine",
                                 CityId = 1,
                                 PostalCode = "6070"
                },
                new Suburb
                              {
                                  Id = 15,
                                  Name = "Kwamashu",
                                  CityId = 11,
                                  PostalCode = "4359"
                },
                new Suburb
                               {
                                   Id = 16,
                                   Name = "Inanda",
                                   CityId = 11,
                                   PostalCode = "4309"
                },
                new Suburb
                                {
                                    Id = 17,
                                    Name = "Struandale",
                                    CityId = 1,
                                    PostalCode = "6001"
                },
                new Suburb
                                 {
                                     Id = 18,
                                     Name = "Valencia Park",
                                     CityId = 6,
                                     PostalCode = "1201"
                },
                new Suburb
                                  {
                                      Id = 19,
                                      Name = "Tongaat",
                                      CityId = 11,
                                      PostalCode = "4399"
                },
                new Suburb
                                   {
                                       Id = 20,
                                       Name = "Greyville",
                                       CityId = 11,
                                       PostalCode = "4001"
                },
                new Suburb
                {
                    Id = 21,
                    Name = "Malabar",
                    CityId = 1,
                    PostalCode = "6020"
                },
                new Suburb
                {
                    Id = 22,
                    Name = "Summerstrand",
                    CityId = 1,
                    PostalCode = "6001"
                });

            builder.Entity<City>().HasData(
                new City
                {
                    Id = 1,
                    Name = "Gqeberha",
                    ProvinceId = 3,
                },
                new City
                {
                    Id = 2,
                    Name = "Johannesburg",
                    ProvinceId = 4,
                },
                new City
                {
                    Id = 3,
                    Name = "Bhisho",
                    ProvinceId = 3,
                },
                new City
                {
                    Id = 4,
                    Name = "Polokwane",
                    ProvinceId = 6,
                },
                new City
                {
                    Id = 5,
                    Name = "Bloemfontein",
                    ProvinceId = 5,
                },
                new City
                {
                    Id = 6,
                    Name = "Mbombela",
                    ProvinceId = 7,
                },
                new City
                {
                    Id = 7,
                    Name = "Mahikeng",
                    ProvinceId = 2,
                },
                new City
                {
                    Id = 8,
                    Name = "Kimberley",
                    ProvinceId = 8,
                },
                new City
                {
                    Id = 9,
                    Name = "Cape Town",
                    ProvinceId = 1,
                },
                new City
                {
                    Id = 10,
                    Name = "Pietermarizburg",
                    ProvinceId = 9,
                },
                new City
                {
                    Id = 11,
                    Name = "Durban",
                    ProvinceId = 9,
                });
            builder.Entity<Province>().HasData(
                new Province
                {
                    Id = 1,
                    Name = "Western Cape"
                },
                new Province
                {
                    Id = 2,
                    Name = "North West"
                },
                new Province
                {
                    Id = 3,
                    Name = "Eastern Cape"
                },
                new Province
                {
                    Id = 4,
                    Name = "Gauteng"
                },
                new Province
                {
                    Id = 5,
                    Name = "Free State"
                },
                new Province
                {
                    Id = 6,
                    Name = "Limpopo"
                },
                new Province
                {
                    Id = 7,
                    Name = "Mpumalanga"
                },
                new Province
                {
                    Id = 8,
                    Name = "Northern Cape"
                },
                new Province
                {
                    Id = 9,
                    Name = "KwaZulu-Natal"
                });

            builder.Entity<Diagnosis>().HasData(
                new Diagnosis
                {
                    Id = 1,
                    ICD10_Code = "F90.9",
                    Description = "Attention Deficit Disorder"
                },
                new Diagnosis
                {
                    Id = 2,
                    ICD10_Code = "E05.9",
                    Description = "Hyperthyroidism"
                },
                new Diagnosis
                {
                    Id = 3,
                    ICD10_Code = "G43.909",
                    Description = "Migraine"
                },
                new Diagnosis
                {
                    Id = 4,
                    ICD10_Code = "M54.9",
                    Description = "Back Pain"
                },
                new Diagnosis
                {
                    Id = 5,
                    ICD10_Code = "I10.9",
                    Description = "Hypertension"
                },
                new Diagnosis
                {
                    Id = 6,
                    ICD10_Code = "J45.909",
                    Description = "Asthma "
                },
                new Diagnosis
                {
                    Id = 7,
                    ICD10_Code = "E78.5",
                    Description = "High Cholesterol"
                });

        }
        public DbSet<User> Users { get; set; }

        public DbSet<City> City { get; set; }
        public DbSet<Contra_Indication> Contra_Indications { get; set; }
        public DbSet<Diagnosis> Diagnosis { get; set; }
        public DbSet<Dosage_Form> Dosage_Form { get; set; }
        public DbSet<History_Medication> History_Medication { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<Med_Ingredients> Med_Ingredients { get; set; }
        public DbSet<Medical_History> Medical_History { get; set; }
        public DbSet<Medicine> Medicine { get; set; }
        public DbSet<Patient_Allergy> Patient_Allergies { get; set; }
        public DbSet<Pharmacy> Pharmacy { get; set; }
        public DbSet<Practice> Practice { get; set; }
        public DbSet<Prescription> Prescription { get; set; }
        public DbSet<Prescription_Details> Prescription_Details { get; set; }
        public DbSet<Province> Province { get; set; }
        public DbSet<Qualification> Qualification { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Severity> Severity { get; set; }
        public DbSet<Suburb> Suburb { get; set; }
        public DbSet<MedSize> Size { get; set; }
        //public DbSet<> Entities { get; set; }
    }
}