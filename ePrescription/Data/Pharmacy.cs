using ePrescription.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
namespace ePrescription.Data
{
    public class Pharmacy
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;
         
        [Required]
        [Display(Name = "Contact Number")]
        public string ContactNo { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Licence Number")]
        public string LicenceNo { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; } = string.Empty;

        [Display(Name = "Address Line 2")]
        public string? AddressLine2 { get; set; }

        [Required]
        public int SuburbID { get; set; }

        //[Display(Name = "Pharmacist")]
        //public string? PharmacistId { get; set; } = string.Empty;

        //Navigation Properties
        public User? Pharmacist { get; set; }

        public Suburb Suburb { get; set; }

    }
}
