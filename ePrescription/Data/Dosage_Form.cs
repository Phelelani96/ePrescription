namespace ePrescription.Data
{
    public class Dosage_Form
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;

        //Navigation Properties
        public ICollection<Medicine>? Medicines { get; set; }
    }
}
