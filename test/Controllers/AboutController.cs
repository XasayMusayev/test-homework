using Microsoft.AspNetCore.Mvc;

namespace test.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewData["a"] = "xasay";
            return View();
        }

        public int ShowId(int id)
        {
            return id;
        }
    }
}
