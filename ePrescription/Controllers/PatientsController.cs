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
                .Where(p => p.Discriminator == "Patient")
                .ToListAsync();
        }
    }
}
