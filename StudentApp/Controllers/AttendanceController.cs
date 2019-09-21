using StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentApp.Controllers
{
    public class AttendanceController : Controller
    {
        private TCMSDBEntities _db = new TCMSDBEntities();

        // GET: Attendance
        public ActionResult Attendance()
        {
            return View();
        }

    }
}