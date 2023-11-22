using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaAB104.DAL;
using ProniaAB104.Models;

namespace ProniaAB104.Areas.ProniaAdmin.Controllers
{
    [Area("ProniaAdmin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            List<Category> categories =await _context.Categories.Include(c=>c.Products).ToListAsync();

            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async  Task<IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            //Office -- oFFice
            //office -- office 
            bool result = _context.Categories.Any(c => c.Name.ToLower().Trim() == category.Name.ToLower().Trim());

            if (result)
            {
                ModelState.AddModelError("Name", "Bele bir Category artiq movcuddur");
                return View();
            }

            await  _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }


    }
}
