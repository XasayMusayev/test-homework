using Microsoft.AspNetCore.Mvc;
using test.Models;

namespace test.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<Student>
            {
                new Student
                {
                    Name = "Xasay",
                    Surname = "Musayev",
                    Age = 20,
                    Country = "Azerbaijan",
                    PhoneNumber = 0708378337
                },

                new Student
                {
                    Name = "Ismayil",
                    Surname = "Hesenov",
                    Age = 21,
                    Country = "Azerbaijan",
                    PhoneNumber = 0702282228
                }
            };

            
            return View(students);
        }
    }
}
