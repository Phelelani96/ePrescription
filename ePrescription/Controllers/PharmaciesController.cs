using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ePrescription.Controllers
{
    public class PharmaciesController : Controller
    {
        // GET: PharmaciesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PharmaciesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PharmaciesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PharmaciesController/Create
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

        // GET: PharmaciesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PharmaciesController/Edit/5
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

        // GET: PharmaciesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PharmaciesController/Delete/5
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
