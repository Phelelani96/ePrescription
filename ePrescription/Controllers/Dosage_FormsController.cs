using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ePrescription.Controllers
{
    public class Dosage_FormsController : Controller
    {
        // GET: Dosage_FormsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: Dosage_FormsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Dosage_FormsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dosage_FormsController/Create
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

        // GET: Dosage_FormsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Dosage_FormsController/Edit/5
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

        // GET: Dosage_FormsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Dosage_FormsController/Delete/5
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
