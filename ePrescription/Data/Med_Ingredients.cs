namespace ePrescription.Data
{
    public class Med_Ingredients
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public int IngredientId { get; set; }
        public int MedicineId { get; set; }
        public string Strength { get; set; }

        public Ingredients? Ingredient { get; set; }
        public Medicine? Medicine { get; set; }
    }
}
