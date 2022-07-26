namespace ePrescription.Data
{
    public class Contra_Indication
    {
        public int Id { get; set; }
        public int DiagnosisId { get; set; }
        public int IngredientId { get; set; }
        public int SeverityId { get; set; }

        //Navigation Properties
        public Diagnosis Diagnosis { get; set; }
        public Ingredients Ingredient { get; set; }
        public Severity Severity { get; set; }

    }
}
