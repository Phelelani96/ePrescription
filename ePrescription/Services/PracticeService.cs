using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ePrescription.Services
{
    public class PracticeService
    {
        private readonly ApplicationDbContext _context;

        public PracticeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Practice>> GetAll()
        {
            return await _context.Practice.ToListAsync();
        }
        public async Task<Practice> GetPracticeAsync(int id)
        {
            var practice =  await _context.Practice.FirstOrDefaultAsync(p => p.Id == id);
            return practice;
        }

        //[HttpPost]
        public async Task<bool> DeletePracticeAsync(int? id)
        {
            bool result = false;

            if (id != null)
            {
                var p = await _context.Practice.FirstOrDefaultAsync(p => p.Id == id);
                if (p != null)
                {
                    _context.Practice.Remove(p);
                    _context.SaveChanges();
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }
        public  async Task AddPractice(Practice practice)
        {
           
               _context.Practice.Add(practice);
            
                await _context.SaveChangesAsync();
        }
        public async Task UpdatePractice(int? Id, Practice practice)
        {
            if (Id != null)
            {
                var p = await _context.Practice.FirstOrDefaultAsync(p => p.Id == Id);
                if (p != null)
                {
                    _context.Practice.Update(p);
                }
                //else
                //{

                //}
            }

            //_context.Practice.Add(practice);

            await _context.SaveChangesAsync();
        }

        public async Task<List<Suburb>> GetSuburbsAsync()
        {
            return await _context.Suburb.ToListAsync();
        }
    }
}
