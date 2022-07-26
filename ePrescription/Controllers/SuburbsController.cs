﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ePrescription.Controllers
{
    public class SuburbsController : Controller
    {
        // GET: SuburbsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SuburbsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SuburbsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuburbsController/Create
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

        // GET: SuburbsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SuburbsController/Edit/5
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

        // GET: SuburbsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SuburbsController/Delete/5
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
