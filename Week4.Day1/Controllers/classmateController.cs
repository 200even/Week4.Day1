using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Week4.Day1.Models;

namespace Week4.Day1.Controllers
{
    public class ClassmateController : Controller
    {

        public ActionResult ListClassMates()
        {
            List<Student> BackendClass = new List<Student>();
            BackendClass.Add(new Student() { FirstName = "Scott", LastName = "Ferguson", HairColor = "Light Brown", HeightInches = 70 });
            BackendClass.Add(new Student() { FirstName = "Aaron", LastName = "Hudson", HairColor = "Dark Brown", HeightInches = 73 });
            BackendClass.Add(new Student() { FirstName = "Mike", LastName = "Null", HairColor = "Light Brown", HeightInches = 70 });
            BackendClass.Add(new Student() { FirstName = "David", LastName = "Plate", HairColor = "Brown", HeightInches = 75 });
            BackendClass.Add(new Student() { FirstName = "Jason", LastName = "Williams", HairColor = "Dark Brown", HeightInches = 70 });
            BackendClass.Add(new Student() { FirstName = "Brandon", LastName = "Goza", HairColor = "Brown", HeightInches = 71 });

            return View(BackendClass);
        }
    }
}