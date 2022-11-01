namespace ePrescription.Data
{
    public class Severity
    {
        public int Id { get; set; }
        public string Level { get; set; } = String.Empty;

        public ICollection<Contra_Indication>? Contra_Indications { get; set; }
    }
}
