namespace ePrescription.Services
{
    public interface IPrescriptionService
    {
        public Task<List<Prescription>> GetPrescriptionsAsync();
        public Task<Prescription> GetPrescriptionAsync(int? id);
        public Task<List<Prescription>> GetUserPrescriptionsAsync(string? id);
        public Task<bool> DeletePrescriptionAsync(int? id);

        public Task<bool> AddPrescriptionAsync(Prescription prescription);
        public Task<bool> UpdatePrescriptionAsync(int id,Prescription prescription);
    }
}
