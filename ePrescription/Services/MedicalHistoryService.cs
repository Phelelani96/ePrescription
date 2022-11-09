using ePrescription.Data.Viewmodels;
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

        public async Task<ServiceResponse<List<Medical_History>>> GetHistory(string? id)
        {
            var response = new ServiceResponse<List<Medical_History>>();
            try
            {
                response.Data = await _context.Medical_History
                    .Include(x => x.History)
                        .ThenInclude(mh => mh.Medicine)
                    .Include(x => x.Patient)
                    .Include(x => x.Diagnosis)
                    .Where(x => x.PatientId == id)
                    .ToListAsync();
                return response;

            }
            catch
            {
                response.Success = false;
                response.Message = "Failed to retrieve data. If this persists, please contact your system";
                return response;
            }
        }

        public async Task<List<Diagnosis>> GetDiagnosesAsync()
        {
            return await _context.Diagnosis.ToListAsync();
        }

        public async Task<List<Medicine>> GetMedicinesAsync()
        {
            return await _context.Medicine.ToListAsync();
        }

        public async Task<ServiceResponse<bool>> AddMedicalHistoryAsync(PatientHistoryViewModel med)
        {
            var m = new ServiceResponse<bool>();
            var history = new Medical_History();
            var medhistory = new History_Medication();
            
            List<CheckItem> list = new List<CheckItem>();  

            if(med != null )
            {
                history = new Medical_History();
                history.Id = med.Id;
                history.PatientId = med.PatientId;
                history.DiagnosisId = med.DiagnosisId;
                history.DiagnosisDate = med.DiagnosisDate;
               
                foreach(var me in med.Medication)
                {
                    if(me.IsChecked == true)
                    {
                        list.Add(new CheckItem(me.Id, me.Name, me.IsChecked));
                    }

                   
                    //x.Medical_HistoryId = med.Id;
                    //x.MedicineId = me.Id;
                    //await _context.History_Medication.AddAsync(x);
                }
                if (list != null)
                {
                    _context.Medical_History.Add(history);
                    await _context.SaveChangesAsync();
                    foreach (var item in list)
                    {
                        medhistory = new History_Medication();

                        medhistory.Medical_HistoryId = history.Id;
                        medhistory.MedicineId = item.Id;
                        medhistory.StartDate = history.DiagnosisDate;


                        _context.History_Medication.Add(medhistory);
                        await _context.SaveChangesAsync();
                    }
                }
                else
                {
                    m.Data = false;
                    m.Message = "Failed to add Medical History. No Medicine selected.";
                    m.Success = false;
                }
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
