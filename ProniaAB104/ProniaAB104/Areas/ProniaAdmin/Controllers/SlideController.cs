using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaAB104.DAL;
using ProniaAB104.Models;

namespace ProniaAB104.Areas.ProniaAdmin.Controllers
{
    [Area("ProniaAdmin")]
    public class SlideController : Controller
    {
        private readonly AppDbContext _context;

        public SlideController(AppDbContext context)
        {
            _context = context;
        }
        public async  Task<IActionResult> Index()
        {
            List<Slide> slides = await _context.Slides.ToListAsync();

            return View(slides);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Slide slide)
        {

            if (slide.Photo is null)
            {
                ModelState.AddModelError("Photo", "Mutleq shekil secilmelidir");
                return View();
            }
            if (!slide.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "File tipi uygun deyil");
                return View();
            }
            if (slide.Photo.Length>2*1024*1024)
            {
                ModelState.AddModelError("Photo", "Sheklin hecmi 2 mb-den boyuk olmamalidir");
                return View();
            }

            FileStream file = new FileStream(@"C:\Users\sabir\Desktop\AB104\ProniaAB104\ProniaAB104\wwwroot\assets\images\slider\" + slide.Photo.FileName,FileMode.Create);

            await slide.Photo.CopyToAsync(file);
            file.Close();
            slide.Image = slide.Photo.FileName;

            await _context.Slides.AddAsync(slide);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}
