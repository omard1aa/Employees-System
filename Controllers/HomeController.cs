using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webapp.Models;

namespace webapp.Controllers
{
    
    public class HomeController : Controller
    {
        private IEmployee employee;
        public HomeController(IEmployee iEmployee){
             employee = iEmployee;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public ViewResult Employees()
        {
            //var emp = employee.GetEmployee(1);
            // ViewData["emp"] = employee.GetEmployee(1);
            //AppDbContext context = new AppDbContext();
            var emps = employee.GetAll();
            return View(emps);
        }
        public ViewResult Add(Employee emp){
            string id = (Request.Form["Id"]).ToString();

            emp.Id = Convert.ToInt32(id);
            emp.Name = Request.Form["Name"];
            emp.Address = Request.Form["Address"];
            string age = Request.Form["Age"];
            emp.Age = Convert.ToInt32(age);
            emp.Mail = Request.Form["Mail"].ToString();
            employee.Add(emp);
            return View(emp);
        }
        public ViewResult getAdd(){

            return View();
        }
        public ViewResult Update(int? id){
            return View();
        }
        public ViewResult Delete(int id){
            employee.Delete(id);
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
