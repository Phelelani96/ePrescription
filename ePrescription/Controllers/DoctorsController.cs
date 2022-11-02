using ePrescription.Areas.Identity.Data;
using ePrescription.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ePrescription.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        public DoctorsController(ApplicationDbContext context, SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        //private readonly RoleManager<>

        // GET: DoctorsController
        public async Task<ServiceResponse<List<User>>> Index()
        {
            var response = new ServiceResponse<List<User>>();
            try
            {
                response.Data = await _context.Users.Where(u => u.Discriminator == "Doctor").ToListAsync();
                return response;
            }
            catch
            {
                response.Message = "An error occured while retrieving the data. If this persists, please contact the system administrator";
                response.Success = false;
                return response;
            }
            
        }

        // GET: DoctorsController/Details/5
        public async Task<ServiceResponse<User>> Details(string id)
        {
            var response = new ServiceResponse<User>();
            try
            {
                if(id == null)
                {
                    response.Message = "An error occured while retrieving the data. If this persists, please contact the system administrator";
                    response.Success = false;
                    return response;
                }
                response.Data = await _context.Users.Where(u => u.Discriminator == "Doctor").FirstOrDefaultAsync(u => u.Id == id);
                return response;
            }
            catch
            {
                response.Message = "An error occured while retrieving the data. If this persists, please contact the system administrator";
                response.Success = false;
                return response;
            }
            
        }

        // GET: DoctorsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DoctorsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ServiceResponse<bool>> Create(User user)
        {
            var response = new ServiceResponse<bool>();
            User doctor = new User();
            try
            {
                doctor.FirstName = user.FirstName;
                doctor.LastName = user.LastName;
                doctor.Email = user.Email;
                doctor.UserName = user.Email;
                doctor.IDNumber = user.IDNumber;
                doctor.AddressLine1 = user.AddressLine1;
                doctor.AddressLine2 = user.AddressLine2;
                doctor.SuburbID = user.SuburbID;
                doctor.QualificationId = user.QualificationId;
                doctor.RegistrationNo = user.RegistrationNo;
                doctor.PracticeId = user.PracticeId;
                doctor.Discriminator = "Doctor";
                doctor.PhoneNumber = user.PhoneNumber;
                doctor.EmailConfirmed = true;

                var result = await _userManager.CreateAsync(doctor, "A"+doctor.FirstName + "123!");
                if(result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, Roles.Doctor.ToString());
                    response.Data = true;
                    response.Success = true;
                    return response;
                }
                else
                {
                    response.Data = false;
                    response.Message = "Failed to add Doctor. If this persists, please contact your system administrator.";
                    return response;
                }
                
            }
            catch
            {
                response.Data = false;
                response.Message = "Failed to add Doctor. If this persists, please contact your system administrator.";
                return response;
            }
        }
        public async Task<List<Suburb>> GetSuburbsAsync()
        {
            return await _context.Suburb.ToListAsync();
        }
        public async Task<List<Qualification>> GetQualificationsAsync()
        {
            return await _context.Qualification.ToListAsync();
        }
        public async Task<List<Practice>> GetPracticesAsync()
        {
            var result =  _context.Practice.Where(p => p.Doctor == null);
            return await result.ToListAsync();
        }



        // GET: DoctorsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DoctorsController/Edit/5
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

        // GET: DoctorsController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: DoctorsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
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
