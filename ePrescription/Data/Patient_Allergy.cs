using ePrescription.Areas.Identity.Data;

namespace ePrescription.Data
{
    public class Patient_Allergy
    {
        public int Id { get; set; }
        public string PatientId { get; set; } = string.Empty;

        public int IngredientId { get; set; }

        public User Patient { get; set; }

        public Ingredients Ingredients { set; get; }
    }
}
