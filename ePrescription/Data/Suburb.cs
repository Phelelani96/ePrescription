using ePrescription.Areas.Identity.Data;

namespace ePrescription.Data
{
    public class Suburb
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public int CityId { get; set; }


        //Navigation Properties
        public City City { get; set; }
        public ICollection<Pharmacy>? Pharmacies { get; set; }
        public ICollection<Practice>? Practices { get; set; }
        public ICollection<User>? Users { get; set; }

    }
}
