using ePrescription.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
namespace ePrescription.Data
{
    public class Medical_History
    {
        public int Id { get; set; }

        [Required]
        public string PatientId { get; set; } = string.Empty;

        [Required]
        public int DiagnosisId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DiagnosisDate { get; set; }

        
        // Nav properties
        public User? Patient { get; set; }

        public Diagnosis? Diagnosis { get; set; }

        public ICollection<Medical_History>? History { get; set; }
    }
}
