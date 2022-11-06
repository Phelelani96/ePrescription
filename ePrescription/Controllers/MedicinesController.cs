using ePrescription.Data.Viewmodels;
using ePrescription.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ePrescription.Controllers
{
    public class MedicinesController : Controller
    {
        private readonly ApplicationDbContext _Context;
        public MedicinesController(ApplicationDbContext Context)
        {
            _Context = Context;
        }
        // GET: MedicinesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MedicinesController/Details/5
        public async Task<List<Ingredients>> GetIngredientsAsync()
        {
            return await _Context.Ingredients.ToListAsync();
        }
        public async Task<List<Dosage_Form>> GetDosagesAsync()
        {
            return await _Context.Dosage_Form.ToListAsync();
        }
        public async Task<List<Schedule>> GetSchedulesAsync()
        {
            return await _Context.Schedule.ToListAsync();
        }

        // GET: MedicinesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MedicinesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ServiceResponse<bool>> Create(MedicineViewModel medicine)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                
                return response;
            }
            catch
            {
                return response;
            }
        }

        // GET: MedicinesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MedicinesController/Edit/5
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

        //// GET: MedicinesController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: MedicinesController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
