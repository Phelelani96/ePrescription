using ePrescription.Shared;
using Microsoft.Build.Framework;

namespace ePrescription.Data.Viewmodels
{
    public class PatientHistoryViewModel
    {
        public int Id { get; set; }
        public string PatientId { get; set; }
        
        public int DiagnosisId { get; set; }
        [Required]
        public DateTime DiagnosisDate { get; set; }

        public List<CheckItem> Medication { get; set; }
    }
}
