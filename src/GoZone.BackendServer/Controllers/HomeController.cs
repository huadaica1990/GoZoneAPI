using Microsoft.AspNetCore.Mvc;

namespace GoZone.BackendServer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
