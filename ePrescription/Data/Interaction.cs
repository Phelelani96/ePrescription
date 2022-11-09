using System.ComponentModel.DataAnnotations;

namespace ePrescription.Data
{
    public class Interaction
    {
        public int Id { get; set; }
        [Required]
        [Range(1, 100000000, ErrorMessage = "Please select Ingredient")]
        public int Ingredient1Id { get; set; }

        [Required]
        [Range(1, 100000000, ErrorMessage = "Please select Ingredient")]
        public int Ingredient2Id { get; set; }

        public Ingredients? Ingredient1 { get; set; }
        public Ingredients? Ingredient2 { get; set; }
    }
}
