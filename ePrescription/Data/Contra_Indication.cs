using System.ComponentModel.DataAnnotations;

namespace ePrescription.Data
{
    public class Contra_Indication
    {
        public int Id { get; set; }
        [Range(1,100000000, ErrorMessage = "Please select Condition")]
        public int DiagnosisId { get; set; }
        [Range(1, 100000000, ErrorMessage = "Please select Ingredient")]
        public int IngredientId { get; set; }
        //public int SeverityId { get; set; }

        //Navigation Properties
        public Diagnosis? Diagnosis { get; set; }
        public Ingredients? Ingredient { get; set; }
        //public Severity? Severity { get; set; }

    }
}
