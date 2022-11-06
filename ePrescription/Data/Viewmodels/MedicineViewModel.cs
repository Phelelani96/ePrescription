using ePrescription.Shared;
using System.ComponentModel.DataAnnotations;

namespace ePrescription.Data.Viewmodels
{
    public class MedicineViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Dosage form")]
        public int Dosage_FormId { get; set; }
        [Required]
        [Display(Name = "Size")]
        public string MedSizeId { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Schedule")]
        public int ScheduleId { get; set; }

        public List<CheckItem> ActiveIngredients { get; set; }
    }
}
