namespace ePrescription.Data
{
    public class Province
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        //Navigation Properties
        public ICollection<City>? Cities { get; set; }

    }
}
