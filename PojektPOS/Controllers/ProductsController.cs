using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PojektPOS.Data;

namespace PojektPOS.Controllers
{
    [Authorize]
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index(string searchString)
        {
            var products = from product in _context.Products select product;
/*            var productsInt = default(IQueryable<Products>);
            var productsString = default(IQueryable<Products>);
            var productsList = new List<Products>();*/


            if (!string.IsNullOrWhiteSpace(searchString))
            {
                products = products.Where(x => x.Name.Contains(searchString) ||
                    x.Id.ToString().Contains(searchString) || 
                    x.Size.Contains(searchString) ||
                    x.EanCode.Contains(searchString) ||
                    x.ProducerCode.Contains(searchString) ||
                    x.Price.ToString().Contains(searchString) ||
                    x.Count.ToString().Contains(searchString) ||
                    x.Manufacturer.Contains(searchString));
/*                var valueType = int.TryParse(searchString, out int valueResult);
                if (valueType)
                    productsInt = products
                        .Where(s => s.Id == valueResult || s.Price == valueResult || s.Count == valueResult);
                productsString = products.Where(s => s.Name.ToString .Contains(searchString) || s.Size.Contains(searchString) ||
                s.ProducerCode.Contains(searchString) || s.EanCode.Contains(searchString) || s.Manufacturer.Contains(searchString));              
                if (productsInt.Any())
                    foreach (var product in productsInt)
                        productsList.Add(product);
                if (productsString.Any())
                    foreach (var product in productsString)
                        productsList.Add(product);
                products = productsList.Distinct().AsQueryable<Products>();*/
            }
            return products != null ?
                          View(await products.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Products'  is null.");
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var products = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Size,EanCode,ProducerCode,Price,Count,Manufacturer,PhotoUrl")] Products products)
        {
            if (ModelState.IsValid)
            {
                _context.Add(products);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(products);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var products = await _context.Products.FindAsync(id);
            if (products == null)
            {
                return NotFound();
            }
            return View(products);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Size,EanCode,ProducerCode,Price,Count,Manufacturer,PhotoUrl")] Products products)
        {
            if (id != products.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(products);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductsExists(products.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(products);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var products = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Products == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Products'  is null.");
            }
            var products = await _context.Products.FindAsync(id);
            if (products != null)
            {
                _context.Products.Remove(products);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductsExists(int id)
        {
            return (_context.Products?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
