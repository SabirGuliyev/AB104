using Microsoft.AspNetCore.Mvc;

namespace MVCIntro.Controllers
{
    
    public class CorporativeSalesController : Controller
    {
        [Route("korporativ-satishlar")]
        public IActionResult Index()
        {
            return View();

            //return RedirectToAction("Detail","Product");
        }

        public IActionResult Test()
        {
            return Content("Teste yonlendirildi");
        }
    }
}
