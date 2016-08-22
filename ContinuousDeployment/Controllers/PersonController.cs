using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContinuousDeployment.Models;

namespace ContinuousDeployment.Controllers
{
    public class PersonController : Controller
    {
        private static List<Person> _people;
         
        public PersonController()
        {
            _people = new List<Person>();
            _people.Add(new Person()
            {
                Name = "Andrew",
                PhoneNumber = "555-1212"
            });
            _people.Add(new Person()
            {
                Name = "Kevin",
                PhoneNumber = "555-1234"
            });
        }
    
        // GET: Person
        public ActionResult Index()
        {
            return View(_people);
        }

        public ActionResult Details(string name)
        {
            var person = _people.FirstOrDefault(p => p.Name == name);

            return View(person);
        }

    }
}