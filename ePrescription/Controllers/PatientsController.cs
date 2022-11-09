using ePrescription.Areas.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ePrescription.Controllers
{
    public class PatientsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PatientsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<User>> GetPatientsAsync()
        {
            return await _context.Users
                .Include(P => P.Medical_History)
                .Where(p => p.Discriminator == "Patient" && p.Status == "Active")
                .ToListAsync();
        }

        public async Task<User> GetPatientAsync(string id)
        {
            return await _context.Users
                .Include(p => p.Suburb)
                    .ThenInclude(s => s.City)
                .Include(p => p.Medical_History)
                    .ThenInclude(m => m.Diagnosis)
                 .Include(p => p.Medical_History)
                    .ThenInclude(m => m.History)
                .Where(p => p.Discriminator == "Patient" && p.Status == "Active")
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
