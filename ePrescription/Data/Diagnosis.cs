using System.ComponentModel.DataAnnotations;

namespace ePrescription.Data
{
    public class Diagnosis
    {
        public int Id { get; set; }
        [Required]
        public string ICD10_Code { get; set; }
        [Required]
        public string Description { get; set; }

        //Nabigation..
        public ICollection<Medical_History>? Medical_Histories { get; set; }
        //public ICollection<Contra_Indication> Contra_Indications { get; set; }
    }
}
