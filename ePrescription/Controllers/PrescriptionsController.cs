using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ePrescription.Controllers
{
    public class PrescriptionsController : Controller
    {
        // GET: PrescriptionsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PrescriptionsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PrescriptionsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PrescriptionsController/Create
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

        // GET: PrescriptionsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PrescriptionsController/Edit/5
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

        // GET: PrescriptionsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PrescriptionsController/Delete/5
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
