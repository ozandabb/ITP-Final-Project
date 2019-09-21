using StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentApp.Controllers
{
    public class MarksController : Controller
    {
        private TCMSDBEntities _db = new TCMSDBEntities();

        // GET: Marks
        public ActionResult Index()
        {
            var marks = from ma in _db.marksInfoes select ma;

            return View(marks);
        }

        // GET: Marks/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Marks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Marks/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Marks/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Marks/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Marks/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Marks/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
