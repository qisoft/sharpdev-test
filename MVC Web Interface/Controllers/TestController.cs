using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Web_Interface.Models;

namespace MVC_Web_Interface.Controllers
{
    public class TestController : Controller
    {
        [Route("test")]
        public ActionResult Index()
        {
            var context = new MyContext();
            var pupil = new Pupil()
            {
                FirstName = "Test",
                SecondName = "Pupil",
                BirthDate = new DateTime(1992,05,14)
            };
            context.Pupils.Add(pupil);
            context.SaveChanges();
            context.Adults.Add(new AdultPerson()
            {
                FirstName = "Test",
                SecondName = "Parent",
                Parent = new Parent()
                {
                    Pupils = new List<Pupil>()
                    {
                        pupil
                    }
                }
            });
            context.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}