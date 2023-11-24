using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaAB104.DAL;
using ProniaAB104.Models;
using ProniaAB104.Utilities.Extensions;

namespace ProniaAB104.Areas.ProniaAdmin.Controllers
{
    [Area("ProniaAdmin")]
    public class SlideController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SlideController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
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
            if (!slide.Photo.ValidateType("image/"))
            {
                ModelState.AddModelError("Photo", "File tipi uygun deyil");
                return View();
            }
            if (!slide.Photo.ValidateSize(2*1024))
            {
                ModelState.AddModelError("Photo", "Sheklin hecmi 2 mb-den boyuk olmamalidir");
                return View();
            }

           
            slide.Image =await slide.Photo.CreateFile(_env.WebRootPath,"assets","images","slider");

            await _context.Slides.AddAsync(slide);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));


        }

        public async Task<IActionResult> Update(int id)
        {
            if (id <= 0) return BadRequest();

            Slide existed = await _context.Slides.FirstOrDefaultAsync(s => s.Id == id);

            if (existed is null) return NotFound();

            return View(existed);

        }
        [HttpPost]
        public async Task<IActionResult> Update(int id,Slide slide)
        {
            Slide existed = await _context.Slides.FirstOrDefaultAsync(s => s.Id == id);

            if (existed is null) return NotFound();
            if (!ModelState.IsValid)
            {
                return View(existed);
            }


            if (slide.Photo is not null)
            {
                if (!slide.Photo.ValidateType("image/"))
                {
                    ModelState.AddModelError("Photo", "File tipi uygun deyil");
                    return View(existed);
                }
                if (!slide.Photo.ValidateSize(2 * 1024))
                {
                    ModelState.AddModelError("Photo", "Sheklin hecmi 2 mb-den boyuk olmamalidir");
                    return View(existed);
                }
                string newImage =await slide.Photo.CreateFile(_env.WebRootPath, "assets", "images", "slider");
                existed.Image.DeleteFile(_env.WebRootPath, "assets", "images", "slider");
                existed.Image = newImage;

            }

            existed.Title=slide.Title;
            existed.Description=slide.Description;
            existed.SubTitle = slide.SubTitle;
            existed.Order = slide.Order;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

            
           
        }
        public async Task<IActionResult> Delete(int id)
        {
            if (id<=0) return BadRequest();

            Slide slide=await _context.Slides.FirstOrDefaultAsync(s=>s.Id==id);

            if (slide is null) return NotFound();

            slide.Image.DeleteFile(_env.WebRootPath, "assets", "images", "slider");
            

            _context.Slides.Remove(slide);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }

    }
}
