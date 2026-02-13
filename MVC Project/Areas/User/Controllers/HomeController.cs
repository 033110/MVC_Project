using Microsoft.AspNetCore.Mvc;

namespace MVC_Project.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
