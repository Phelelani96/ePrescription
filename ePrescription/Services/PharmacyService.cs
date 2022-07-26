using Microsoft.EntityFrameworkCore;

namespace ePrescription.Services
{
    public class PharmacyService
    {
        private readonly ApplicationDbContext _context;

        public PharmacyService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Pharmacy>> GetPharmaciesAsync()
        {
            try
            {
                return await _context.Pharmacy.ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }
           
        }

        public async Task<Pharmacy> GetPharmacyByIdAsync(int? id)
        {
           
            try
            {
                if(id != null)
                {
                    var pharmacy = await _context.Pharmacy.FirstOrDefaultAsync(p => p.Id == id);
                    if(pharmacy != null)
                    {
                        return pharmacy;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
               
            }
            catch
            {
                return null;
            }
            
            
        }
        
        public async Task<bool> AddPharmacyAsync(Pharmacy pharmacy)
        {
            bool success = false;
            try
            {
                await _context.Pharmacy.AddAsync(pharmacy);
                _context.SaveChanges();
                success = true;
                return success;
            }
            catch
            {
                success = false;
                return success;
            }

            //return success;

        }

        public async Task<bool> UpdatePharmacyAync(int? id)
        {
            bool success = false;
            if (id == null)
            {
                return success;
            }
            else
            {
                var pharmacy = await _context.Pharmacy.FirstOrDefaultAsync(p => p.Id == id);
                if (pharmacy == null)
                {
                    return success;
                }
                else
                {
                    _context.Pharmacy.Update(pharmacy);
                    _context.SaveChanges();
                    success = true;
                    return success;
                }
            }
        }

        public async Task<bool> DeletePharmacyAsync(int? id)
        {
            bool success = false;
            if (id == null)
            {
                return success;
            }
            else
            {
                var pharmacy = await _context.Pharmacy.FirstOrDefaultAsync(p => p.Id == id);
                if (pharmacy == null)
                {
                    return success;
                }
                else
                {
                    _context.Pharmacy.Remove(pharmacy);
                    _context.SaveChanges();
                    success = true;
                    return success;
                }
            }
        }

        public async Task<List<Suburb>> GetSuburbsAsync()
        {
            return await _context.Suburb.ToListAsync();
        }
    }
}
