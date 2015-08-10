using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer.Models;
using DataLayer.Repositories;

namespace MVC_Web_Interface.Controllers
{
    public class TestController : Controller
    {
        private readonly IStudentRepository _students;

        public TestController(IStudentRepository students)
        {
            this._students = students;
        }

        [Route("test")]
        public ActionResult Index()
        {
            var students = _students.Get(1);
            students.Class = "8б";
            _students.Save(students);
            return Json(students, JsonRequestBehavior.AllowGet);
        }
    }
}