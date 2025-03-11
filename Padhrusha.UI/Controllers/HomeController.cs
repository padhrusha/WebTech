using Microsoft.AspNetCore.Mvc;

namespace Padhrusha.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
