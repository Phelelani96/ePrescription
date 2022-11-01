namespace ePrescription.Data
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public int ProvinceId { get; set; }

        //Navigation Properties
        public ICollection<Suburb>? Suburbs { get; set; }   
        public Province? Province { get; set; }
    }
}
