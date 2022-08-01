using ePrescription.Shared;

namespace ePrescription.Services
{
    public interface IPracticeService
    {
        public Task<ServiceResponse<List<Practice>>> GetAll();
        public Task<ServiceResponse<Practice>> GetPracticeAsync(int id);
        public Task<ServiceResponse<bool>> DeletePracticeAsync(int id);
        public Task<ServiceResponse<bool>> AddPractice(Practice practice);
        public Task<ServiceResponse<bool>> UpdatePractice(int Id);
        public Task<List<Suburb>> GetSuburbsAsync();
    }
}
