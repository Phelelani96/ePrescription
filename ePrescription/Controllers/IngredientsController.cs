using ePrescription.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ePrescription.Controllers
{
    
    public class IngredientsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public IngredientsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: IngredientsController
        public async Task<ServiceResponse<List<Ingredients>>> Index()
        {
            var response = new ServiceResponse<List<Ingredients>>();
            response.Data = await _context.Ingredients.ToListAsync();
            return response;
        }

        // GET: IngredientsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: IngredientsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IngredientsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ServiceResponse<bool>> Create(Ingredients ingredient)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                if(_context.Ingredients.Any(i => i.Description == ingredient.Description))
                {
                    response.Success = false;
                    response.Message = "Ingredient already exists";
                    return response;
                }
                else
                {
                    _context.Add(ingredient);
                    await _context.SaveChangesAsync();
                    response.Message = "Ingredient added successfully!";
                    return response;
                }
                
            }
            catch
            {
                response.Success = false;
                response.Message = "Failed to add Ingredient. If this persists, contact your system administrator.";
                return response;
            }
        }

        // GET: IngredientsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: IngredientsController/Edit/5
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

        // GET: IngredientsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: IngredientsController/Delete/5
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
