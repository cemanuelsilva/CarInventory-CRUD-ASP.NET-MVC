using Microsoft.AspNetCore.Mvc;

namespace LearnApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
