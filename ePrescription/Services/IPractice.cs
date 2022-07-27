namespace ePrescription.Services
{
    public interface IPractice
    {
        public Task<List<Practice>> GetAll();
        public Task<Practice> GetPracticeAsync(int id);
        public Task<bool> DeletePracticeAsync(int? id);
        public Task AddPractice(Practice practice);
        public Task UpdatePractice(int? Id);
        public Task<List<Suburb>> GetSuburbsAsync();
    }
}
