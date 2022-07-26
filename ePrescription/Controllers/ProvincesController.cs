using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ePrescription.Controllers
{
    public class ProvincesController : Controller
    {
        // GET: ProvincesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProvincesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProvincesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProvincesController/Create
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

        // GET: ProvincesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProvincesController/Edit/5
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

        // GET: ProvincesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProvincesController/Delete/5
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
