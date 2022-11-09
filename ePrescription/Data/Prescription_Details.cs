using ePrescription.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;

namespace ePrescription.Data
{
    public class Prescription_Details
    {
        public int Id { get; set; }

        public int MedicineId { get; set; }
        public int PrescriptionId { get; set; }

        [Required]
        public int Quantity { get; set; }
        [Required]
        public int Repetition { get; set; }
        public int RepetitionLeft { get; set; }
        public string? PharmacistId { get; set; }
        public string Instructions { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Comments { get; set; } = string.Empty;


        //Navigation Properties
        public User? Pharmacist { get; set; }
        public Medicine? Medicine { get; set; }
        public Prescription? Prescription { get; set; }
    }
}
