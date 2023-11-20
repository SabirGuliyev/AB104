using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaAB104.DAL;
using ProniaAB104.Models;

namespace ProniaAB104.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Detail(int id)
        {
            if (id <= 0) return BadRequest();
          
            Product product = _context.Products.Include(p=>p.Category).FirstOrDefault(p=>p.Id==id);

            List<Product> products = _context.Products.Where(p => p.CategoryId == product.CategoryId).ToList();
            if (product is null) return NotFound();
           


           


            return View(product);
        }
    }
}
