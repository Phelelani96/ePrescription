using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ePrescription.Controllers
{
    public class MedicinesController : Controller
    {
        // GET: MedicinesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MedicinesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MedicinesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MedicinesController/Create
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

        // GET: MedicinesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MedicinesController/Edit/5
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

        // GET: MedicinesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MedicinesController/Delete/5
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
