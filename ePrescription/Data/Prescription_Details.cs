using ePrescription.Areas.Identity.Data;

namespace ePrescription.Data
{
    public class Prescription_Details
    {
        public int Id { get; set; }
        public int MedicineId { get; set; }
        public int PrescriptionId { get; set; }
        public int Quantity { get; set; }
        public int Repetition { get; set; }
        public string PharmacistId { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Comments { get; set; } = string.Empty;


        //Navigation Properties
        public User? Pharmacist { get; set; }
        public Medicine? Medicine { get; set; }
        public Prescription? Prescription { get; set; }
    }
}
