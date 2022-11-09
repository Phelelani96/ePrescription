using System.ComponentModel.DataAnnotations;

namespace ePrescription.Data
{
    public class History_Medication
    {
        public int Id { get; set; }

        //[Range(1, 100000000, ErrorMessage = "Please select Condition")]
        public int Medical_HistoryId { get; set; }

        [Range(1, 100000000, ErrorMessage = "Please select Condition")]
        public int MedicineId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        //Navigation Properties
        public Medical_History? Medical_History { get; set; }
        public Medicine? Medicine { get; set; }
    }
}
