using CarShop.Data;
using CarShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Controllers
{
    public class PartController : Controller
    {
        private Repository<Part> parts;

        public PartController(ApplicationDbContext context)
        {
            parts = new Repository<Part>(context);
        }
        public async Task<IActionResult> Index()
        {
            return View(await parts.GetAllAsync());
        }

        public async Task<IActionResult> Details(int id)
        {
            return View(await parts.GetByIdAsync(id, new QueryOptions<Part>() {Includes="ProductParts.Product"}));
        }

        //Part/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PartId, Name")] Part part)
        {
            if (ModelState.IsValid)
            {
                await parts.AddAsync(part);
                return RedirectToAction("Index");
            }
            return View(part);
        }

        //Ingredient/Delete
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            return View(await parts.GetByIdAsync(id, new QueryOptions<Part> { Includes = "ProductParts.Product" }));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Part part)
        {
            await parts.DeleteAsync(part.PartId);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            return View(await parts.GetByIdAsync(id, new QueryOptions<Part> { Includes = "ProductParts.Product" }));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Part part)
        {
            if (!ModelState.IsValid)
            {
                await parts.UpdateAsync(part);
                return RedirectToAction("Index");
            }
            return View(part);
        }
    }
}
