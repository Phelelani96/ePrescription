using ePrescription.Shared;
using Microsoft.EntityFrameworkCore;

namespace ePrescription.Services
{
    public class MedicalHistoryService : IMedicalHistoryService
    {
        private readonly ApplicationDbContext _context;

        public MedicalHistoryService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Diagnosis>> GetDiagnosesAsync()
        {
            return await _context.Diagnosis.ToListAsync();
        }

        public async Task<List<Medicine>> GetMedicinesAsync()
        {
            return await _context.Medicine.ToListAsync();
        }

        public async Task<ServiceResponse<bool>> AddMedicalHistoryAsync(Medical_History med,IEnumerable<Medicine> medicines)
        {
            var m = new ServiceResponse<bool>();
            var x = new History_Medication();
            if(med != null )
            {
                await _context.Medical_History.AddAsync(med);
                foreach(var me in medicines)
                {
                    x.Medical_HistoryId = med.Id;
                    x.MedicineId = me.Id;
                    await _context.History_Medication.AddAsync(x);
                }
                _context.SaveChanges();
                m.Data = true;
                m.Message = "Successfully added Medical History";
                m.Success = true;
            }
            else
            {
                m.Data = false;
                m.Message = "Failed to add Medical History";
                m.Success = false;
            }
            return m;
        }
    }
}
