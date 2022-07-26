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
                   
                },

                new User
                {
                    Id = "abc-123-ABC-246-eee",
                    FirstName = "Doctor",
                    LastName = "Strange",
                    IDNumber = "8611223659874",
                    Email = "strange@gmail.com",
                    NormalizedEmail = "STRANGE@GMAIL.COM",
                    PhoneNumber = "0780509025",
                    UserName = "strange@gmail.com",
                    NormalizedUserName = "STRANGE@GMAIL.COM",
                    Discriminator = "Doctor",
                    AddressLine1 = "1 2th Avenue",
                    SuburbID = 1,
                    PracticeId = 3,
                    QualificationId = 1,
                    RegistrationNo = "123456789",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "Strange123!")

                },
                new User
                {
                    Id = "abc-123-ABC-246-ccc",
                    FirstName = "Peter",
                    LastName = "Parker",
                    IDNumber = "9911262654123",
                    Email = "parker@gmail.com",
                    NormalizedEmail = "PARKER@GMAIL.COM",
                    PhoneNumber = "0780509071",
                    UserName = "parker@gmail.com",
                    NormalizedUserName = "PARKER@GMAIL.COM",
                    Discriminator = "Pharmacist",
                    AddressLine1 = "8th Avenue",
                    SuburbID = 3,
                    PharmacyId = 2,
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "Peter123!")

                }
                );

            builder.Entity<Practice>().HasData(
                new Practice
                {
                    Id = 1,
                    Name = "Practice",
                    Email = "info@practice.com",
                    ContactNo = "0456987456",
                    AddressLine1 = "1 Practice Street",
                    SuburbID = 1,
                    PracticeNo = "12365477"
                });

            builder.Entity<Pharmacy>().HasData(
                new Pharmacy
                {
                    Id = 1,
                    Name = "Pharmacy",
                    Email = "info@pharmacy.com",
                    ContactNo = "0475557456",
                    AddressLine1 = "1 Pharmacy Street",
                    SuburbID = 1,
                    LicenceNo = "12365477",
                    
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
                 },
                  new IdentityUserRole<string>
                  {
                      RoleId = "3",
                      UserId = "abc-123-ABC-246-ccc"
                  });

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
                    Name = "Summerstrand",
                    CityId = 1,
                    PostalCode = "6001"
                },
                new Suburb
                {
                    Id = 2,
                    Name = "Humewood",
                    CityId = 1,
                    PostalCode = "6002"
                },
                new Suburb
                {
                    Id = 3,
                    Name = "Walmer",
                    CityId = 1,
                    PostalCode = "6003"
                });

            builder.Entity<City>().HasData(
                new City
                {
                    Id = 1,
                    Name = "Gqeberha",
                    ProvinceId = 1,
                },
                new City
                {
                    Id = 2,
                    Name = "East London",
                    ProvinceId = 1,
                },
                new City
                {
                    Id = 3,
                    Name = "Makhanda",
                    ProvinceId = 1,
                });
            builder.Entity<Province>().HasData(
                new Province
                {
                    Id = 1,
                    Name = "Eastern Cape"
                });

          
        }
        public DbSet<User> Users { get; set; }

        public DbSet<City> City { get; set; }
        public DbSet<Contra_Indication>  Contra_Indications { get; set; }
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
        //public DbSet<> Entities { get; set; }
        //public DbSet<> Entities { get; set; }
    }
}