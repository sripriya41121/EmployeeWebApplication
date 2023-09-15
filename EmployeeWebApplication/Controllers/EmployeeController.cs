using EmployeeWebApplication.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EmployeeWebApplication.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index(int deptId)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> employees = employeeContext.Employees.Where(emp=>emp.DepartmentId==deptId).ToList();
            return View(employees);
        }

        public ActionResult Details(int id)
        {
           EmployeeContext employeeContext = new EmployeeContext();
           Employee employee = employeeContext.Employees.Single(x => x.EmployeeId == id);
            return View(employee);
        }
    }
}