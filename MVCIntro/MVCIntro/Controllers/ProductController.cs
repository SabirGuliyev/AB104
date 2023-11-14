using Microsoft.AspNetCore.Mvc;

namespace MVCIntro.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View("product");
        }
    }
}
