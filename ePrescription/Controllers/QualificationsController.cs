using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ePrescription.Controllers
{
    public class QualificationsController : Controller
    {
        // GET: QualificationsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: QualificationsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QualificationsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QualificationsController/Create
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

        // GET: QualificationsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QualificationsController/Edit/5
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

        // GET: QualificationsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QualificationsController/Delete/5
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
