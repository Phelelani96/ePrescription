using ePrescription.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ePrescription.Controllers
{
    public class Contra_IndicationsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public Contra_IndicationsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: Contra_IndicationsController
        public async Task<List<Contra_Indication>> Index()
        {
            return await _context.Contra_Indications
                .Include(c => c.Ingredient)
                .Include(c => c.Diagnosis)
                .ToListAsync();
        }

        // GET: Contra_IndicationsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Contra_IndicationsController/Create
        public async Task<List<Ingredients>> GetIngredients()
        {
            return await _context.Ingredients.ToListAsync();
        }
        public async Task<List<Diagnosis>> GetDiagnoses()
        {
            return await _context.Diagnosis.ToListAsync();
        }

        // POST: Contra_IndicationsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ServiceResponse<bool>> Create(Contra_Indication contra)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                if(await exists(contra.IngredientId, contra.DiagnosisId))
                {
                    response.Data = false;
                    response.Message = "Failed to add record. Record already exists";
                    response.Success = false;
                    return response;
                }
                _context.Add(contra);
                await _context.SaveChangesAsync();
                response.Data = true;
                response.Message = "Record successfully added!";
                return response;
            }
            catch
            {
                response.Data = false;
                response.Message = "Failed to add record. If this persists, contact your system administrator.";
                response.Success = false;
                return response;
            }
        }

        // GET: Contra_IndicationsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Contra_IndicationsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: Contra_IndicationsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Contra_IndicationsController/Delete/5
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

        public async Task<bool> exists(int medId, int diagId)
        {
            bool x;
            if(_context.Contra_Indications.Any(c => c.DiagnosisId == diagId && c.IngredientId == medId))
            {
                x = true;
            }
            else
            {
                x = false;
            }
            return x;
        }
    }
}
