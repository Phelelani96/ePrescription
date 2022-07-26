using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ePrescription.Controllers
{
    public class DiagnosesController : Controller
    {
        // GET: DiagnosesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DiagnosesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DiagnosesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DiagnosesController/Create
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

        // GET: DiagnosesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DiagnosesController/Edit/5
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

        // GET: DiagnosesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DiagnosesController/Delete/5
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
