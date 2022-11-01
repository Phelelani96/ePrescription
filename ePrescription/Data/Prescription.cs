using ePrescription.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;

namespace ePrescription.Data
{
    public class Prescription
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }    

        public string PatientId { get; set; } = string.Empty;
        public string DoctorId { get; set; } = string.Empty;

        public User? Patient { get; set; }
        public User? Doctor { get; set; }
        //public ICollection<Prescription_Details> Prescription_Details {get; set; }
    }  
}
