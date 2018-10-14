using System;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Library.Models;
using System.Web;

namespace Library.Controllers
{
    public class EmployeeController : BaseController
    {
        // GET: Employee
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult AddEmployee(string firstName, string lastName,string password,string phoneNumber ,string Email,DateTime hiredate, float salary, HttpPostedFileBase cv)
        {

            UserManager.CreateAsync(new ApplicationUser() {
                UserName = Email,
                hireDate=hiredate,
                Salary = salary,
                PhoneNumber = phoneNumber
                
            },password);

            return View();
        }
    }
}