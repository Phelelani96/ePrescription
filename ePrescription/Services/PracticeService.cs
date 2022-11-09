using ePrescription.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ePrescription.Services
{
    public class PracticeService: IPracticeService
    {
        private readonly ApplicationDbContext _context;

        public PracticeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Practice>>> GetAll()
        {
            var response = new ServiceResponse<List<Practice>>();
            try
            {
                response.Data = await _context.Practice.Include(p => p.Suburb).ToListAsync();
                return response;
            }
            catch
            {
                response.Message = "An error occured while retrieving the data. If this persists, please contact the system administrator";
                response.Success = false;
                return response;
            }
           
        }
        public async Task<ServiceResponse<Practice>> GetPracticeAsync(int id)
        {
            var response = new ServiceResponse<Practice>();
            try
            {
                response.Data = await _context.Practice.FirstOrDefaultAsync(p => p.Id == id);
                if(response.Data == null)
                {
                    response.Message = "Practice does not exist";
                    response.Success = false;
                }
              return response;
            }
            catch
            {
                response.Message = "An error occured while retrieving the data. If this persists, please contact the system administrator";
                response.Success = false;
                return response;
            }
            //var practice =  await _context.Practice.FirstOrDefaultAsync(p => p.Id == id);
            //return practice;
        }

      
        public async Task<ServiceResponse<bool>> DeletePracticeAsync(int id)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                var p = await _context.Practice.FirstOrDefaultAsync(p => p.Id == id);
                if (p != null)
                {
                    _context.Practice.Remove(p);
                    _context.SaveChanges();
                    response.Message = "Practice successfully deleted!";
                }
                else
                {
                    response.Success = false;
                    response.Message = "Practice not found";
                }
                return response;
            }
            catch
            {
                response.Success = false;
                response.Message = "Failed to delete Practice.If this persists, please contact your system administrator.";
                return response;
            }
        }


        public async Task<List<Suburb>> GetSuburbsAsync()
        {
            return await _context.Suburb.ToListAsync();
        }

        public async Task<ServiceResponse<bool>> AddPractice(Practice practice)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                await _context.Practice.AddAsync(practice);
                await _context.SaveChangesAsync();
                response.Data = true;
                response.Message = practice.Name + " Added successfully!";
                return response;
            }
            catch
            {
                response.Data = false;
                response.Message = "Failed to add Practice. If this persists, please contact your system administrator.";
                return response;
            }
        }

        public async Task<ServiceResponse<bool>> UpdatePractice(int Id)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                var p = await _context.Practice.FindAsync(Id);
                if(p == null)
                {
                    response.Data = false;
                    response.Success = false;
                    response.Message = "Failed to update practice.";
                }
                else
                {
                    _context.Practice.Update(p);
                    await _context.SaveChangesAsync();
                    response.Data = true;
                    response.Message = "Successfully updated Practice";
                }
                return response;
            }
            catch
            {
                response.Data = false;
                response.Success = false;
                response.Message = "Failed to update practice. If this persists, please contact your system administrator. ";
                return response;
            }
        }

    }
}
