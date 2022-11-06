using ePrescription.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ePrescription.Controllers
{
    public class DiagnosesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public DiagnosesController(ApplicationDbContext context)
        {
            _context = context;     
        }
        // GET: DiagnosesController
        public async Task<ServiceResponse<List<Diagnosis>>> Index()
        {
            var response = new ServiceResponse<List<Diagnosis>>();
            try
            {
                response.Data = await _context.Diagnosis.ToListAsync();
                return response;
            }
            catch
            {
                response.Message = "An error occured while retrieving the data. If this persists, please contact the system administrator";
                response.Success = false;
                return response;
            }
            
        }

        // GET: DiagnosesController/Details/5
        public async Task<ServiceResponse<Diagnosis>> Details(int id)
        {
            var response = new ServiceResponse<Diagnosis>();
            try
            {
                if(id == null)
                {
                    response.Data = null;
                    response.Success = false;
                    response.Message = "Record not found!";
                    return response;
                }
                response.Data = await _context.Diagnosis.FirstOrDefaultAsync(c => c.Id == id);
                if(response.Data == null)
                {
                    response.Data = null;
                    response.Success = false;
                    response.Message = "Record not found!";
                    return response;
                }
                else
                {
                    //response.Message = "Record not found!";
                    return response;
                }
                
            }
            catch
            {
                response.Data = null;
                response.Success = false;
                response.Message = "Failed to retrieve data. If this persists, contact your system administrator.";
                return response;
            }
        }

        // GET: DiagnosesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DiagnosesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ServiceResponse<bool>> Create(Diagnosis diagnosis)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                _context.Add(diagnosis);
                await _context.SaveChangesAsync();
                response.Data = true;
                response.Message = "Successfully added condition!";
                return response;
            }
            catch
            {
                response.Data = false;
                response.Success = false;
                response.Message = "Failed to add diagnosis. If thisi persists, contact your system administrator";
                return response;
            }
        }

        // GET: DiagnosesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DiagnosesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ServiceResponse<bool>> Edit(int id, Diagnosis diagnosis)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                if (id == null)
                {
                    //response.Data = null;
                    response.Success = false;
                    response.Message = "Record not found!";
                    return response;
                }
                var a = await _context.Diagnosis.FindAsync(id);
                if (a == null)
                {
                    //response.Data = null;
                    response.Success = false;
                    response.Message = "Record not found!";
                    return response;
                }
                else
                {
                    _context.Update(diagnosis);
                    await _context.SaveChangesAsync();
                    response.Data = true;
                    response.Message = "Successfully updated condition!";
                    return response;
                    //return response;
                }
               
            }
            catch
            {
                response.Data = false;
                response.Success = false;
                response.Message = "Failed to update diagnosis. If this persists, contact your system administrator";
                return response;
            }
        }

        // GET: DiagnosesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DiagnosesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
