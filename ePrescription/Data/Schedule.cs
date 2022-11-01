namespace ePrescription.Data
{
    public class Schedule
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;

        public ICollection<Medicine>? Medicines { get; set; }
    }
}
