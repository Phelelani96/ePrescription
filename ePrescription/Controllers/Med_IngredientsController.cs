using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ePrescription.Controllers
{
    public class Med_IngredientsController : Controller
    {
        // GET: Med_IngredientsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: Med_IngredientsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Med_IngredientsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Med_IngredientsController/Create
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

        // GET: Med_IngredientsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Med_IngredientsController/Edit/5
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

        // GET: Med_IngredientsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Med_IngredientsController/Delete/5
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
