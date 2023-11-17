using Microsoft.AspNetCore.Mvc;
using ProniaAB104.DAL;
using ProniaAB104.Models;

namespace ProniaAB104.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<Slide> slides=_context.Slides.OrderBy(s=>s.Order).Take(2).ToList();

            //_context.Slides.AddRange(slides);
            //_context.SaveChanges();


            return View(slides) ;
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
