using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ePrescription.Controllers
{
    public class SeveritiesController : Controller
    {
        // GET: SeveritiesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SeveritiesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SeveritiesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SeveritiesController/Create
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

        // GET: SeveritiesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SeveritiesController/Edit/5
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

        // GET: SeveritiesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SeveritiesController/Delete/5
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
