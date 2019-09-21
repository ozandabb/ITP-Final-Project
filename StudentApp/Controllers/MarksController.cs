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
            //return View(_db.Students.Where(x => x.Full_Name.Contains(search) || search == null).ToList());
        }

        // GET: Marks/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Marks/Create
        public ActionResult Create()
        {
            marksInfo ex = new marksInfo();
            ex.examCollection = _db.exams.ToList<exam>();
            ex.stuCollection = _db.Students.ToList<Student>();
            ex.subCollection = _db.subjects.ToList<subject>();
            return View(ex);
        }

        // POST: Marks/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "id")] marksInfo marksToCreate)
        {
            if (!ModelState.IsValid)
                return View();

            _db.marksInfoes.Add(marksToCreate);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Marks/Edit/5
        public ActionResult Edit(int id)
        {
            //var marksToEdit = (from m in _db.marksInfoes
            //                   where m.m_id == id
            //                   select m).First();
            return View();
        }

        // POST: Marks/Edit/5
        [HttpPost]
        public ActionResult Edit(marksInfo marksToEdit)
        {
            //var originalMarks = (from m in _db.marksInfoes
            //                    where m.m_id == marksToEdit.m_id
            //                    select m).First();

            //if (!ModelState.IsValid)
            //    return View(originalMarks);

            //_db.Entry(originalMarks).CurrentValues.SetValues(marksToEdit);
            //_db.SaveChanges();

            //return RedirectToAction("Index");
            return View();
        }

        // GET: Marks/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            marksInfo marksToDelete = _db.marksInfoes.Find(id);
            if (marksToDelete == null)
            {
                return HttpNotFound();
            }
            return View(marksToDelete);
           
        }

        // POST: Marks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            marksInfo marksToDelete = _db.marksInfoes.Find(id);
            _db.marksInfoes.Remove(marksToDelete);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
