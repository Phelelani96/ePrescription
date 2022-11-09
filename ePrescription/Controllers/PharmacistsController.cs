using ePrescription.Areas.Identity.Data;
using ePrescription.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ePrescription.Controllers
{
    public class PharmacistsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        public PharmacistsController(ApplicationDbContext context, SignInManager<User> signInManager, UserManager<User> userManager)
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
                response.Data = await _context.Users
                    .Include(d => d.Pharmacy)
                    .Where(u => u.Discriminator == "Pharmacist" && u.Status == "Active").ToListAsync();
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
                if (id == null)
                {
                    response.Message = "An error occured while retrieving the data. If this persists, please contact the system administrator";
                    response.Success = false;
                    return response;
                }
                response.Data = await _context.Users.Where(u => u.Discriminator == "Pharmacist").FirstOrDefaultAsync(u => u.Id == id);
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
            User pharmacist = new User();
            try
            {
                pharmacist.FirstName = user.FirstName;
                pharmacist.LastName = user.LastName;
                pharmacist.Email = user.Email;
                pharmacist.UserName = user.Email;
                pharmacist.IDNumber = user.IDNumber;
                pharmacist.AddressLine1 = user.AddressLine1;
                pharmacist.AddressLine2 = user.AddressLine2;
                //pharmacistor.SuburbID = user.SuburbID;
                //pharmacistor.QualificationId = user.QualificationId;
                pharmacist.RegistrationNo = user.RegistrationNo;
                pharmacist.PharmacyId = user.PharmacyId;
                pharmacist.Discriminator = user.Discriminator;
                pharmacist.Status = "Active";
                pharmacist.PhoneNumber = user.PhoneNumber;
                pharmacist.EmailConfirmed = true;

                if (_context.Users.Any(u => u.Email == pharmacist.Email))
                {
                    response.Data = false;
                    response.Message = "Failed to add Pharmacist. Email already exists";
                    return response;
                }
                var result = await _userManager.CreateAsync(pharmacist, "A" + pharmacist.FirstName + "123!");
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(pharmacist, Roles.Pharmacist.ToString());
                    response.Data = true;
                    response.Success = true;
                    return response;
                }
                else
                {
                    response.Data = false;
                    response.Message = "Failed to add Pharmacist. If this persists, please contact your system administrator.";
                    return response;
                }

            }
            catch
            {
                response.Data = false;
                response.Message = "Failed to add Pharmacist. If this persists, please contact your system administrator.";
                return response;
            }
        }
        //public async Task<List<Suburb>> GetSuburbsAsync()
        //{
        //    return await _context.Suburb.ToListAsync();
        //}
      
        public async Task<List<Pharmacy>> GetPharmaciesAsync()
        {
            //var result =  _context.Practice;
            return await _context.Pharmacy.ToListAsync();
        }



        // GET: DoctorsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DoctorsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ServiceResponse<bool>> Edit(string id, User user)
        {
            var response = new ServiceResponse<bool>();
            //User doctor = new User();
            try
            {

                //if (id != null)
                var pharmacist = await _context.Users.FirstOrDefaultAsync(d => d.Id == id);
                if (pharmacist != null)
                {
                    pharmacist.FirstName = user.FirstName;
                    pharmacist.LastName = user.LastName;
                    pharmacist.Email = user.Email;
                    //pharmacistoc.QualificationId = user.QualificationId;
                    pharmacist.RegistrationNo = user.RegistrationNo;
                    pharmacist.PharmacyId = user.PharmacyId;
                    pharmacist.PhoneNumber = user.PhoneNumber;
                    _context.Update(pharmacist);
                    await _context.SaveChangesAsync();
                    response.Data = true;
                    response.Success = true;
                    return response;

                }
                else
                {
                    response.Data = false;
                    response.Message = "Pharmacist was not found!";
                    return response;
                }

            }
            catch
            {
                response.Data = false;
                response.Message = "Failed to update Pharmacist. If this persists, please contact your system administrator.";
                return response;
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
        public async Task<ServiceResponse<bool>> Delete(string id)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                if (id == null)
                {
                    response.Success = false;
                    response.Data = false;
                    response.Message = "Doctor does not exist";
                }
                var doctor = await _context.Users.FindAsync(id);
                if (doctor == null)
                {
                    response.Success = false;
                    response.Data = false;
                    response.Message = "Doctor does not exist";
                }

                doctor.Status = "Inactive";
                _context.SaveChanges();
                response.Data = true;
                response.Message = "Sucessfully removed " + doctor.FullName;
                return response;
            }
            catch
            {
                response.Success = false;
                response.Data = false;
                response.Message = "An error occured. If this persists, please contact the system administrator";
                return response;
            }
        }
    }
}

