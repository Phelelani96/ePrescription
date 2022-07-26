using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ePrescription.Controllers
{
    public class History_MedicationsController : Controller
    {
        // GET: History_MedicationsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: History_MedicationsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: History_MedicationsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: History_MedicationsController/Create
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

        // GET: History_MedicationsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: History_MedicationsController/Edit/5
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

        // GET: History_MedicationsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: History_MedicationsController/Delete/5
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
