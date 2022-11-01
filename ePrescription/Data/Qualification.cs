using ePrescription.Areas.Identity.Data;

namespace ePrescription.Data
{
    public class Qualification
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;

        public ICollection<User>? Doctors { get; set; }
    }
}
