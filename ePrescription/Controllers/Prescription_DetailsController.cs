using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ePrescription.Controllers
{
    public class Prescription_DetailsController : Controller
    {
        // GET: Prescription_DetailsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: Prescription_DetailsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Prescription_DetailsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Prescription_DetailsController/Create
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

        // GET: Prescription_DetailsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Prescription_DetailsController/Edit/5
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

        // GET: Prescription_DetailsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Prescription_DetailsController/Delete/5
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
