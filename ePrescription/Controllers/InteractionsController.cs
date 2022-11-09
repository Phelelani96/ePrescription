using ePrescription.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ePrescription.Controllers
{
    public class InteractionsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public InteractionsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Interaction>> Index()
        {
            var response = await _context.Interactions
                .Include(r => r.Ingredient1)
                .Include(r => r.Ingredient2)
                .ToListAsync();
            return response;
        }
        public async Task<ServiceResponse<bool>> Create(Interaction interaction)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                _context.Add(interaction);
                await _context.SaveChangesAsync();
                response.Message = "Medication interaction added successfully!";
                return response;
            }
            catch
            {
                response.Success = false;
                response.Message = "Failed to add interaction. If this persists, contact your system administrator";
                return response;
            }
            
            
        }

        public async Task<List<Ingredients>> GetMedicinesAsync()
        {
            return  await _context.Ingredients.ToListAsync();
           
        }
    }
}
