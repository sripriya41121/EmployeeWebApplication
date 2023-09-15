using EmployeeWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeWebApplication.Controllers
{
    public class RootController : Controller
    {
        // GET: Root
        /* public ActionResult Index()
         {
             return View();
         }

         public string Index()
         {

             return "Hello from Sripriya!";
         }

        public string Index(string id, string name, string department)
        {

            return $"ID is: {id} and Name is: {name} and department is : {department}";

        }

        public List<string> Index() {
            return new List<string>()
            {
                "INDIA",
                "USA",
                "CANADA",
                "UK",
                "JAPAN"

            };
        }*/

        public ActionResult Index()
        {
            ViewBag.Countries = new List<string>()
            {
                "INDIA",
                "USA",
                "CANADA",
                "UK",
                "JAPAN"

            };
            return View();
        }


        public ActionResult Index1()
        {
            ViewData["Countries"] = new List<string>()
            {
                "INDIA",
                "USA",
                "CANADA",
                "UK",
                "JAPAN"

            };
            return View();
        }

        public ActionResult Details()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 1,
                Name = "Priya",
                Gender="Female",
                City="San Jose"
            };
            return View(employee);
        }

    }
}