using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaAB104.Areas.ProniaAdmin.ViewModels;
using ProniaAB104.DAL;
using ProniaAB104.Models;

namespace ProniaAB104.Areas.ProniaAdmin.Controllers
{
    [Area("ProniaAdmin")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public async  Task<IActionResult> Index()
        {

            List<Product> products = await _context.Products
                .Include(p=>p.Category)
                .Include(p=>p.ProductImages.Where(pi=>pi.IsPrimary==true))
                .Include(p => p.ProductTags)
                .ThenInclude(p=>p.Tag)
                .ToListAsync();

            return View(products);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Categories=await _context.Categories.ToListAsync();
            ViewBag.Tags = await _context.Tags.ToListAsync();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateProductVM productVM)
        {
           
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = await _context.Categories.ToListAsync();
                ViewBag.Tags = await _context.Tags.ToListAsync();
                return View();
            }
            bool result = await _context.Categories.AnyAsync(c=>c.Id==productVM.CategoryId);
            if (!result)
            {
                ViewBag.Categories = await _context.Categories.ToListAsync();
                ViewBag.Tags = await _context.Tags.ToListAsync();
                ModelState.AddModelError("CategoryId", "Bu Id li category movcud deyil");
                return View();
            }

            foreach (int tagId in productVM.TagIds)
            {
                bool tagResult = await _context.Tags.AnyAsync(t => t.Id == tagId);
                if (!tagResult)
                {
                    ViewBag.Categories = await _context.Categories.ToListAsync();
                    ViewBag.Tags = await _context.Tags.ToListAsync();
                    ModelState.AddModelError("TagIds","Yanlish tag melumatlari gonderilib");
                    return View();
                }
            }


            Product product = new Product
            {
                Name = productVM.Name,
                Price = productVM.Price,
                SKU = productVM.SKU,
                CategoryId = (int)productVM.CategoryId,
                Description = productVM.Description,
                ProductTags=new List<ProductTag>()

            };

            foreach (int tagId in productVM.TagIds)
            {
                ProductTag productTag = new ProductTag
                {
                    TagId = tagId, 
                };

               product.ProductTags.Add(productTag);

            }
           

            

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

            //tapsiriq
        }

        public async Task<IActionResult> Update(int id)
        {
            if (id <= 0) return BadRequest();
           
            Product product=await _context.Products.Include(p=>p.ProductTags).FirstOrDefaultAsync(p=>p.Id==id);

            if (product is null) return NotFound();

            UpdateProductVM productVM = new UpdateProductVM
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                SKU = product.SKU,
                CategoryId = product.CategoryId,
                TagIds=product.ProductTags.Select(pt=>pt.TagId).ToList(),
                Categories = await _context.Categories.ToListAsync(),
                Tags=await _context.Tags.ToListAsync()
            };

            return View(productVM);
           
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, UpdateProductVM productVM)
        {
            if (!ModelState.IsValid)
            {
                productVM.Categories = await _context.Categories.ToListAsync();
                productVM.Tags = await _context.Tags.ToListAsync();
                return View();
            }

            Product existed = await _context.Products.Include(p => p.ProductTags).FirstOrDefaultAsync(p => p.Id == id);
            if (existed is null) return NotFound();
           
            bool result = await _context.Categories.AnyAsync(c => c.Id == productVM.CategoryId);
            if (!result)
            {
                productVM.Categories = await _context.Categories.ToListAsync();
                productVM.Tags = await _context.Tags.ToListAsync();
                return View();
            }

            foreach (ProductTag proTag in existed.ProductTags)
            {
                if (!productVM.TagIds.Exists(tId=>tId==proTag.TagId))
                {
                    _context.ProductTags.Remove(proTag);
                }
            }

            
            foreach (int tagId in productVM.TagIds)
            {
                if (!existed.ProductTags.Any(pt=>pt.TagId==tagId))
                {

                    existed.ProductTags.Add(new ProductTag
                    {
                        TagId = tagId
                    });
                }
            }

            existed.Name = productVM.Name;
            existed.Description=productVM.Description;
            existed.SKU = productVM.SKU;
            existed.Price = productVM.Price;
            existed.CategoryId = productVM.CategoryId;


            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
