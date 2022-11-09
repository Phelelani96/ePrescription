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
        public async Task<ServiceResponse<List<Medicine>>> Index()
        {
            var response = new ServiceResponse<List<Medicine>>();
            try
            {
                response.Data = await _Context.Medicine
                    .Include(d => d.Med_Ingredients)
                        .ThenInclude(i => i.Ingredient)
                       .Include(d => d.Dosage_Form)
                       .Include(d => d.Schedule)
                    .ToListAsync();
                return response;
            }
            catch
            {
                response.Success = false;
                return response;
            }
            //return View();
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
        public async Task<ServiceResponse<Medicine>> GetMedicineAsync(int id)
        {
            var response = new ServiceResponse<Medicine>();
            try
            {
                if (id == null)
                {
                    response.Success = false;
                    response.Message = "Medicine not found";
                    return response;
                }
                response.Data = await _Context.Medicine
                    .Include(d => d.Med_Ingredients)
                        .ThenInclude(i => i.Ingredient)
                       .Include(d => d.Dosage_Form)
                       .Include(d => d.Schedule)
                       .Where(d => d.Id == id)
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (response.Data == null)
                {
                    response.Success = false;
                    response.Message = "Medicine not found";
                    return response;
                }
                return response;
            }
            catch
            {
                response.Success = false;
                response.Message = "Medicine not found";
                return response;
            }
        }

        // POST: MedicinesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ServiceResponse<bool>> Create(MedicineViewModel medicine)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                Medicine drug = new Medicine();
                List<CheckItem> ingredients = new List<CheckItem>();
                Med_Ingredients med_Ingredients = new Med_Ingredients();
                if(medicine != null)
                {
                    drug.Id = medicine.Id;
                    drug.Name = medicine.Name;
                    drug.ScheduleId = medicine.ScheduleId;
                    drug.Dosage_FormId = medicine.Dosage_FormId;
                    drug.MedSizeId = medicine.MedSizeId;
                    //medicine.ActiveIngredients = items.Select(al => new CheckItem()
                    //{
                    //    Id = al.Id,
                    //    Name = al.Description,
                    //    Strength = "",
                    //    IsChecked = false

                    //}).ToList(); ;
                    foreach(var ai in medicine.ActiveIngredients)
                    {
                        if(ai.IsChecked == true)
                        {
                            ingredients.Add(new CheckItem(ai.Id, ai.Name, ai.Strength, ai.IsChecked));
                        }
                    }
                    if (ingredients == null)
                    {
                        response.Success = false;
                        response.Data = false;
                        response.Message = "No active ingredients selected for this medicine. Please select ingredient and try again.";
                        return response;
                    }
                    else
                    {
                        _Context.Medicine.Add(drug);
                        await _Context.SaveChangesAsync();
                        foreach(var i in ingredients)
                        {
                            med_Ingredients = new Med_Ingredients()
                            {
                                Description = "",
                                IngredientId = i.Id,
                                MedicineId = drug.Id,
                                Strength = i.Strength
                            };
                            _Context.Med_Ingredients.Add(med_Ingredients);
                            await _Context.SaveChangesAsync();
                        }
                        response.Data = true;
                        response.Message = "Medicine added successfully!";
                        return response;
                    }

                }

                return response;
            }
            catch
            {
                response.Success = false;
                response.Data = false;
                response.Message = "Failed to add Medicine. If this persists, please contact your system administrator.";
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
