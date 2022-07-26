using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ePrescription.Controllers
{
    public class Patient_AllergiesController : Controller
    {
        // GET: Patient_AllergiesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: Patient_AllergiesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Patient_AllergiesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Patient_AllergiesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: Patient_AllergiesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Patient_AllergiesController/Edit/5
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

        // GET: Patient_AllergiesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Patient_AllergiesController/Delete/5
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
