using ePrescription.Shared;

namespace ePrescription.Services
{
    public interface IMedicalHistoryService
    {
        public Task<List<Diagnosis>> GetDiagnosesAsync();
        public Task<List<Medicine>> GetMedicinesAsync();
        public Task<ServiceResponse<bool>> AddMedicalHistoryAsync(Medical_History med,IEnumerable<Medicine> medicines);
    }
}
