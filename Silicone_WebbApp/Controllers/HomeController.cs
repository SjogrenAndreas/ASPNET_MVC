using Microsoft.AspNetCore.Mvc;

namespace Silicone_WebbApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
