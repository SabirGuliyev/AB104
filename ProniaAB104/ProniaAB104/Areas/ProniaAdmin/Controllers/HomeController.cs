using Microsoft.AspNetCore.Mvc;

namespace ProniaAB104.Areas.ProniaAdmin.Controllers
{
    [Area("ProniaAdmin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
