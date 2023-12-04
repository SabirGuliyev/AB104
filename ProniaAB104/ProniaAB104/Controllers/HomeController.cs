using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaAB104.DAL;
using ProniaAB104.Models;
using ProniaAB104.ViewModels;

namespace ProniaAB104.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            
            List<Slide> slides=await _context.Slides.OrderBy(s=>s.Order).Take(2).ToListAsync();

            List<Product> products=await _context.Products.Include(p=>p.ProductImages.Where(pi=>pi.IsPrimary!=null)).ToListAsync();
            //_context.Slides.AddRange(slides);
            //_context.SaveChanges();

            HomeVM home=new HomeVM
            {
                Slides=slides,
                Products=products
            };

            
            return View(home);
        }

        public IActionResult About()
        {
            return View();
        }

        //public IActionResult Test()
        //{
        //    Response.Cookies.Append("Score", "5-0", new CookieOptions
        //    {
        //        MaxAge = TimeSpan.FromSeconds(50)
        //    }) ;

        //    HttpContext.Session.SetString("Score2","6-1");
            

        //    return Ok();
        //}

        //public IActionResult GetCookie()
        //{
        //   string score= Request.Cookies["Score"];
        //   string score2= HttpContext.Session.GetString("Score2");
        //    return Content(score+" "+score2);
        //}
    }
}
