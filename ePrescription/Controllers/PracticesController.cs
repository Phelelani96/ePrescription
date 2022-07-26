using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ePrescription.Controllers
{
    public class PracticesController : Controller
    {
        // GET: PracticesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PracticesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PracticesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PracticesController/Create
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

        // GET: PracticesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PracticesController/Edit/5
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

        // GET: PracticesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PracticesController/Delete/5
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
