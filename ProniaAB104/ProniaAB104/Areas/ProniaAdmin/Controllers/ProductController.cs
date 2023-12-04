using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaAB104.Areas.ProniaAdmin.ViewModels;
using ProniaAB104.DAL;
using ProniaAB104.Models;
using ProniaAB104.Utilities.Extensions;

namespace ProniaAB104.Areas.ProniaAdmin.Controllers
{
    [Area("ProniaAdmin")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ProductController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
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

            if (!productVM.MainPhoto.ValidateType("image/"))
            {
                ViewBag.Categories = await _context.Categories.ToListAsync();
                ViewBag.Tags = await _context.Tags.ToListAsync();
                ModelState.AddModelError("MainPhoto", "File tipi uygun deyil");
                return View();
            }
            if (!productVM.MainPhoto.ValidateSize(600))
            {
                ViewBag.Categories = await _context.Categories.ToListAsync();
                ViewBag.Tags = await _context.Tags.ToListAsync();
                ModelState.AddModelError("MainPhoto", "File olcusu uygun deyil:600kb");
                return View();
            }

            if (!productVM.HoverPhoto.ValidateType("image/"))
            {
                ViewBag.Categories = await _context.Categories.ToListAsync();
                ViewBag.Tags = await _context.Tags.ToListAsync();
                ModelState.AddModelError("HoverPhoto", "File tipi uygun deyil");
                return View();
            }
            if (!productVM.HoverPhoto.ValidateSize(600))
            {
                ViewBag.Categories = await _context.Categories.ToListAsync();
                ViewBag.Tags = await _context.Tags.ToListAsync();
                ModelState.AddModelError("HoverPhoto", "File olcusu uygun deyil:600kb");
                return View();
            }

            ProductImage image = new ProductImage
            {
                Alternative=productVM.Name,
                IsPrimary = true,
                Url = await productVM.MainPhoto.CreateFileAsync(_env.WebRootPath, "assets", "images", "website-images")
            };
            ProductImage hoverImage = new ProductImage
            {
                Alternative = productVM.Name,
                IsPrimary = false,
                Url = await productVM.HoverPhoto.CreateFileAsync(_env.WebRootPath, "assets", "images", "website-images")
                
            };

            Product product = new Product
            {
                Name = productVM.Name,
                Price = productVM.Price,
                SKU = productVM.SKU,
                CategoryId = (int)productVM.CategoryId,
                Description = productVM.Description,
                ProductTags=new List<ProductTag>(),
                ProductImages = new List<ProductImage> { image,hoverImage}

            };

            foreach (int tagId in productVM.TagIds)
            {
                ProductTag productTag = new ProductTag
                {
                    TagId = tagId, 
                };

               product.ProductTags.Add(productTag);

            }

            TempData["Message"] = "";
            foreach (IFormFile photo in productVM.Photos)
            {
                if (!photo.ValidateType("image/"))
                {
                    TempData["Message"] += $"<p class=\"text-danger\">{photo.FileName} file tipi uygun deyil</p>";
                    continue;
                }
                if (!photo.ValidateSize(600))
                {
                    TempData["Message"] += $"<p class=\"text-danger\">{photo.FileName} file olcusu uygun deyil</p>";
                    continue;
                }

                product.ProductImages.Add(new ProductImage
                {
                    Alternative = productVM.Name,
                    IsPrimary =null,
                    Url=await photo.CreateFileAsync(_env.WebRootPath, "assets", "images", "website-images")
                });
            }

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

            //tapsiriq
        }

        public async Task<IActionResult> Update(int id)
        {
            if (id <= 0) return BadRequest();
           
            Product product=await _context.Products.Include(p=>p.ProductImages).Include(p=>p.ProductTags).FirstOrDefaultAsync(p=>p.Id==id);

            if (product is null) return NotFound();

            UpdateProductVM productVM = new UpdateProductVM
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                SKU = product.SKU,
                CategoryId = product.CategoryId,
                TagIds=product.ProductTags.Select(pt=>pt.TagId).ToList(),
                ProductImages=product.ProductImages,
                Categories = await _context.Categories.ToListAsync(),
                Tags=await _context.Tags.ToListAsync()
            };

            return View(productVM);
           
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, UpdateProductVM productVM)
        {
            Product existed = await _context.Products.Include(pi=>pi.ProductImages).Include(p => p.ProductTags).FirstOrDefaultAsync(p => p.Id == id);
            productVM.ProductImages = existed.ProductImages;
            if (!ModelState.IsValid)
            {
                productVM.Categories = await _context.Categories.ToListAsync();
                productVM.Tags = await _context.Tags.ToListAsync();
                return View(productVM);
            }

          
            if (existed is null) return NotFound();
           
            bool result = await _context.Categories.AnyAsync(c => c.Id == productVM.CategoryId);
            if (!result)
            {
                productVM.Categories = await _context.Categories.ToListAsync();
                productVM.Tags = await _context.Tags.ToListAsync();
                ModelState.AddModelError("CategoryId", "Bele bir category movcud deyil");
                return View(productVM);
            }
            if (productVM.MainPhoto is not null) 
            {
                if (!productVM.MainPhoto.ValidateType("image/"))
                {
                    productVM.Categories = await _context.Categories.ToListAsync();
                    productVM.Tags = await _context.Tags.ToListAsync();
                    ModelState.AddModelError("MainPhoto", "File novu uygun deyil");
                    return View(productVM);
                }
                if (!productVM.MainPhoto.ValidateSize(600))
                {
                    productVM.Categories = await _context.Categories.ToListAsync();
                    productVM.Tags = await _context.Tags.ToListAsync();
                    ModelState.AddModelError("MainPhoto", "File olcusu uygun deyil");
                    return View(productVM);
                }

            }

            if (productVM.HoverPhoto is not null)
            {
                if (!productVM.HoverPhoto.ValidateType("image/"))
                {
                    productVM.Categories = await _context.Categories.ToListAsync();
                    productVM.Tags = await _context.Tags.ToListAsync();
                    ModelState.AddModelError("HoverPhoto", "File novu uygun deyil");
                    return View(productVM);
                }
                if (!productVM.HoverPhoto.ValidateSize(600))
                {
                    productVM.Categories = await _context.Categories.ToListAsync();
                    productVM.Tags = await _context.Tags.ToListAsync();
                    ModelState.AddModelError("HoverPhoto", "File olcusu uygun deyil");
                    return View(productVM);
                }

            }

           




            existed.ProductTags.RemoveAll(pt => !productVM.TagIds.Exists(tId => tId == pt.TagId));

            List<int> creatable=productVM.TagIds.Where(tId=>!existed.ProductTags.Exists(pt=>pt.TagId==tId)).ToList();
            foreach (int tagId in creatable)
            {
                bool tagResult = await _context.Tags.AnyAsync(t => t.Id == tagId);
                if (!tagResult)
                {
                    productVM.Categories = await _context.Categories.ToListAsync();
                    productVM.Tags = await _context.Tags.ToListAsync();
                    ModelState.AddModelError("TagIds", "Bele bir tag movcud deyil");
                    return View(productVM);
                }
                existed.ProductTags.Add(new ProductTag
                {
                    TagId = tagId
                });
            }

            if (productVM.MainPhoto is not null)
            {
                string fileName = await productVM.MainPhoto.CreateFileAsync(_env.WebRootPath, "assets", "images", "website-images");

                ProductImage mainImage = existed.ProductImages.FirstOrDefault(pi => pi.IsPrimary == true);
                mainImage.Url.DeleteFile(_env.WebRootPath, "assets", "images", "website-images");
                _context.ProductImages.Remove(mainImage);

                existed.ProductImages.Add(new ProductImage
                {
                    Alternative = productVM.Name,
                    IsPrimary = true,
                    Url = fileName
                });
            }
            if (productVM.HoverPhoto is not null)
            {
                string fileName = await productVM.HoverPhoto.CreateFileAsync(_env.WebRootPath, "assets", "images", "website-images");

                ProductImage hoverImage = existed.ProductImages.FirstOrDefault(pi => pi.IsPrimary == false);
                hoverImage.Url.DeleteFile(_env.WebRootPath, "assets", "images", "website-images");
                _context.ProductImages.Remove(hoverImage);

                existed.ProductImages.Add(new ProductImage
                {
                    Alternative = productVM.Name,
                    IsPrimary = false,
                    Url = fileName
                });
            }
            if (productVM.ImageIds is null)
            {
                productVM.ImageIds = new List<int>();
            }
            List<ProductImage> removeable = existed.ProductImages.Where(pi => !productVM.ImageIds.Exists(imgId => imgId == pi.Id) && pi.IsPrimary == null).ToList();
            foreach (ProductImage pImage in removeable)
            {
                pImage.Url.DeleteFile(_env.WebRootPath, "assets", "images", "website-images");
                existed.ProductImages.Remove(pImage);
            }


            TempData["Message"] = "";
            if (productVM.Photos is not null)
            {
                foreach (IFormFile photo in productVM.Photos)
                {
                    if (!photo.ValidateType("image/"))
                    {
                        TempData["Message"] += $"<p class=\"text-danger\">{photo.FileName} file tipi uygun deyil</p>";
                        continue;
                    }
                    if (!photo.ValidateSize(600))
                    {
                        TempData["Message"] += $"<p class=\"text-danger\">{photo.FileName} file olcusu uygun deyil</p>";
                        continue;
                    }

                    existed.ProductImages.Add(new ProductImage
                    {
                        Alternative = productVM.Name,
                        IsPrimary = null,
                        Url = await photo.CreateFileAsync(_env.WebRootPath, "assets", "images", "website-images")
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


        public async Task<IActionResult> Delete( int id)
        {
            if (id <= 0) return BadRequest();

            Product product = await _context.Products.Include(p => p.ProductImages).FirstOrDefaultAsync(p => p.Id == id);

            if (product is null) return NotFound();


            foreach (ProductImage image in product.ProductImages)
            {
                image.Url.DeleteFile(_env.WebRootPath, "assets", "images", "website-images");
            }
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}
