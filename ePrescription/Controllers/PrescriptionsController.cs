using ePrescription.Areas.Identity.Data;
using ePrescription.Shared;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;
using System;
using Microsoft.AspNetCore.Components.Authorization;

using static ePrescription.Pages.Prescriptions.Create;

namespace ePrescription.Controllers
{
    public class PrescriptionsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly AuthenticationStateProvider _provider;
        public PrescriptionsController(ApplicationDbContext context, UserManager<User> userManager, AuthenticationStateProvider provider)
        {
            _context = context;
            _userManager = userManager;
            _provider = provider;
        }
    
        // GET: PrescriptionsController
        public async Task<List<Prescription>> DoctorIndex(string? id)
        {
            var authState = await _provider.GetAuthenticationStateAsync();
            var user = authState.User;
            var x = _userManager.GetUserId(user);
            if (id == null || id == "")
            {
                //string user = _userManager.GetUserId(User);
                return await _context.Prescription
                .Include(p => p.Patient)
                .Include(p => p.Doctor)
                .Include(p => p.Prescription_Details)
                    .ThenInclude(pd => pd.Medicine)
                .Include(p => p.Prescription_Details)
                    .ThenInclude(pd => pd.Pharmacist)
                .Where(p =>  p.DoctorId == x)
                .ToListAsync();
            }
            else
            {
                //string user = _userManager.GetUserId(User);
                return await _context.Prescription
                .Include(p => p.Patient)
                .Include(p => p.Doctor)
                .Include(p => p.Prescription_Details)
                    .ThenInclude(pd => pd.Medicine)
                .Include(p => p.Prescription_Details)
                    .ThenInclude(pd => pd.Pharmacist)
                .Where(p => p.PatientId == id && p.DoctorId == x)
                .ToListAsync();
            }
            
        }
        public async Task<List<Prescription>> PharmacistIndex(string? id)
        {
            if(id == null || id == "")
            {
                return await _context.Prescription
                .Include(p => p.Patient)
                .Include(p => p.Doctor)
                .Include(p => p.Prescription_Details)
                    .ThenInclude(pd => pd.Medicine)
                .Include(p => p.Prescription_Details)
                    .ThenInclude(pd => pd.Pharmacist)
                .ToListAsync();
            }
            else
            {
                return await _context.Prescription
                .Include(p => p.Patient)
                .Include(p => p.Doctor)
                .Include(p => p.Prescription_Details)
                    .ThenInclude(pd => pd.Medicine)
                .Include(p => p.Prescription_Details)
                    .ThenInclude(pd => pd.Pharmacist)
                .Where(p => p.PatientId == id)
                .ToListAsync();
            }
            
        }
        public async Task<List<Prescription>> PatientIndex(string? id)
        {
            var authState = await _provider.GetAuthenticationStateAsync();
            var user = authState.User;
            var x = _userManager.GetUserId(user);
            if(x != null)
            {
                return await _context.Prescription
                 .Include(p => p.Patient)
                 .Include(p => p.Doctor)
                 .Include(p => p.Prescription_Details)
                     .ThenInclude(pd => pd.Medicine)
                 .Include(p => p.Prescription_Details)
                     .ThenInclude(pd => pd.Pharmacist)
                 .Where(p => p.PatientId == x)
                 .ToListAsync();
            }
            else
            {
                return await _context.Prescription
                 .Include(p => p.Patient)
                 .Include(p => p.Doctor)
                 .Include(p => p.Prescription_Details)
                     .ThenInclude(pd => pd.Medicine)
                 .Include(p => p.Prescription_Details)
                     .ThenInclude(pd => pd.Pharmacist)
                 .Where(p => p.PatientId == id)
                 .ToListAsync();
            }
        }


        public async Task<List<Prescription>> DoctorPrescription(string id)
        {
            return await _context.Prescription
                .Include(p => p.Patient)
                .Include(p => p.Doctor)
                .Include(p => p.Prescription_Details)
                    .ThenInclude(pd => pd.Medicine)
                .Include(p => p.Prescription_Details)
                    .ThenInclude(pd => pd.Pharmacist)
                .Where(p => p.PatientId == id)
                .ToListAsync();
        }
        public async Task<List<Prescription>> PharmacisPrescription()
        {
            return await _context.Prescription
                .Include(p => p.Patient)
                .Include(p => p.Doctor)
                .Include(p => p.Prescription_Details)
                    .ThenInclude(pd => pd.Medicine)
                .Include(p => p.Prescription_Details)
                    .ThenInclude(pd => pd.Pharmacist).ToListAsync();
        }
        public async Task<List<Prescription>> PatientPrescription()
        {
            return await _context.Prescription
                .Include(p => p.Patient)
                .Include(p => p.Doctor)
                .Include(p => p.Prescription_Details)
                    .ThenInclude(pd => pd.Medicine)
                .Include(p => p.Prescription_Details)
                    .ThenInclude(pd => pd.Pharmacist).ToListAsync();
        }
        // GET: PrescriptionsController/Details/5
        public async Task<ServiceResponse<bool>> AddDetails(Prescription_Details model)
        {
            //bool x = false;
           var response = new ServiceResponse<bool>();
            try
            {
                if (model != null)
                {
                    //x = true;
                    //Prescription_Details detail1 = new Prescription_Details()
                    //{
                    //    Id = model.prescription_Detail1.Id,
                    //    Repetition = model.prescription_Detail1.Repetition,
                    //    Quantity = model.prescription_Detail1.Quantity,
                    //    Instructions = model.prescription_Detail1.Instructions,
                    //    PrescriptionId = model.prescription_Detail1.PrescriptionId,
                    //    RepetitionLeft = model.prescription_Detail1.Repetition
                    //    //Rep
                    //};
                    _context.Prescription_Details.Add(model);

                }
                //if (model.prescription_Detail2 != null)
                //{
                //    Prescription_Details detail2 = new Prescription_Details()
                //    {
                //        Id = model.prescription_Detail2.Id,
                //        Repetition = model.prescription_Detail2.Repetition,
                //        Quantity = model.prescription_Detail2.Quantity,
                //        Instructions = model.prescription_Detail2.Instructions,
                //        PrescriptionId = model.prescription_Detail2.PrescriptionId,
                //        RepetitionLeft = model.prescription_Detail2.Repetition
                //        //Rep
                //    };
                //    _context.Prescription_Details.Add(detail2);
                //    x = true;

                //}
                //if (model.prescription_Detail3 != null)
                //{
                //    x = true;
                //    Prescription_Details detail3 = new Prescription_Details()
                //    {
                //        Id = model.prescription_Detail3.Id,
                //        Repetition = model.prescription_Detail3.Repetition,
                //        Quantity = model.prescription_Detail3.Quantity,
                //        Instructions = model.prescription_Detail3.Instructions,
                //        PrescriptionId = model.prescription_Detail3.PrescriptionId,
                //        RepetitionLeft = model.prescription_Detail3.Repetition
                //        //Rep
                //    };
                //    _context.Prescription_Details.Add(detail3);
                //}
                _context.SaveChanges();
                response.Message = "Added prescription successfully";
                return response;
            }
            catch
            {
                response.Success = false;
                response.Message = "Failed to add prescription. If this persists, contact your system administrator";
                return response;
            }
        }

        // GET: PrescriptionsController/Create
        public async Task<List<Medicine>> GetMedicine()
        {
            return await _context.Medicine.ToListAsync();
        }

        // POST: PrescriptionsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ServiceResponse<bool>> Create(Prescription model)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                _context.Prescription.Add(model);
                _context.SaveChanges();
                response.Message = model.Id.ToString();
                return response;
            }
            catch
            {
                response.Message = "Failed to add prescription. If this persists, contact your system administrator";
                response.Success = false;
                return response;
            }
        }

        // GET: PrescriptionsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PrescriptionsController/Edit/5
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

        // GET: PrescriptionsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PrescriptionsController/Delete/5
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

        public async Task<ServiceResponse<bool>> DispenseAsync(int id)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                if (id == null)
                {
                    response.Success = false;
                    response.Message = "Record not found!";
                    return response;
                }
                var det = await _context.Prescription_Details.FindAsync(id);
                if(det == null)
                {
                    response.Success = false;
                    response.Message = "Record not found!";
                    return response;
                }
                det.RepetitionLeft = det.RepetitionLeft - 1;
                _context.SaveChanges();
                response.Message = "Dispensed successfully!";
                return response;
            }
            catch
            {
                response.Success = false;
                response.Message = "Failed to dispense. If this persists, contact your sytem administrator";
                return response;
            }
        }
    }
}
