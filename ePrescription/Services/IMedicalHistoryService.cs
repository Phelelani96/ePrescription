using ePrescription.Data.Viewmodels;
using ePrescription.Shared;

namespace ePrescription.Services
{
    public interface IMedicalHistoryService
    {
        public Task<List<Diagnosis>> GetDiagnosesAsync();
        public Task<List<Medicine>> GetMedicinesAsync();
        public Task<ServiceResponse<bool>> AddMedicalHistoryAsync(PatientHistoryViewModel patientHistory);
    }
}
