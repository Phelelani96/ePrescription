using Microsoft.EntityFrameworkCore;

namespace ePrescription.Services
{
    public class PrescriptionService : IPrescriptionService
    {
        private readonly ApplicationDbContext _context;

        public PrescriptionService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> AddPrescriptionAsync(Prescription prescription)
        {
            bool result = false;
            try
            {
                if(prescription != null)
                {
                    _context.Prescription.Add(prescription);
                    await _context.SaveChangesAsync();
                    result = true;
                }

                return result;

            }
            catch
            {
                return result;
            }
        }

        public async Task<bool> DeletePrescriptionAsync(int? id)
        {
            bool result = false;
            try
            {
                if (id == null)
                {
                    return result;
                }
                else
                {
                    var prescription = await _context.Prescription.FindAsync(id);
                    if (prescription != null)
                    {
                        _context.Remove(prescription);
                        await _context.SaveChangesAsync();
                        result = true;
                    }
                    return result;
                }
            }
            catch
            {
                return result;
            }
        }

        public async Task<Prescription> GetPrescriptionAsync(int? id)
        {
            var prescription = new Prescription();
            try
            {
                if(id != null)
                {
                    prescription = await _context.Prescription.FirstOrDefaultAsync(p => p.Id == id);
                    if(prescription != null)
                    {
                        return prescription;
                    }
                    else
                    {
                        return prescription;
                    }
                }
                else
                {
                    return prescription;
                }
            }
            catch
            {
                return prescription;
            }
        }

        public async Task<List<Prescription>> GetPrescriptionsAsync()
        {
            return await _context.Prescription.ToListAsync();
        }

        public async Task<List<Prescription>> GetUserPrescriptionsAsync(string? id)
        {
            return await _context.Prescription
                .Where(p => p.PatientId == id)
                .ToListAsync();
        }

        public async Task<bool> UpdatePrescriptionAsync(int id, Prescription prescription)
        {
            bool result = false;
            try
            {
                var p = await _context.Prescription.FindAsync(id);
                if(p != null)
                {
                    _context.Prescription.Update(p);
                    await _context.SaveChangesAsync();
                    result = true;
                }
                return result;
            }
            catch
            {
                return result;
            }
        }
    }
}
