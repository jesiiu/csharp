using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PojektPOS.Models;
using PojektPOS.Data;
using Microsoft.AspNetCore.Authorization;

namespace PojektPOS.Controllers
{
    [Authorize]
    public class DocumentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DocumentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Documents

        public async Task<IActionResult> Index(string searchString)
        {
            var documents = from document in _context.Documents select document;
            if (!string.IsNullOrWhiteSpace(searchString))
            {
                documents = documents.Where(d => d.Id.ToString().Contains(searchString)||
                    d.Type.Contains(searchString) ||
                    d.Description.Contains(searchString) ||
                    d.Payment.Contains(searchString) ||
                    d.TotalPrice.ToString().Contains(searchString) ||
                    d.TotalCount.ToString().Contains(searchString) 
                    ); 
                /*                var valueType = int.TryParse(searchString, out int valueResult);
                                if (valueType)
                                    documents = documents.Where(s => s.Id == valueResult || s.TotalPrice == valueResult || s.TotalCount == valueResult);         
                                else
                                {
                                    documents = documents.Where(s => s.User.Contains(searchString) || s.Description.Contains(searchString) || 
                                    s.Payment.Contains(searchString) || s.Type.Contains(searchString));
                                } */
            }
              return documents != null ? 
                          View(await documents.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Documents'  is null.");
        }

        // GET: Documents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Documents == null)
            {
                return NotFound();
            }

            var documents = await _context.Documents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (documents == null)
            {
                return NotFound();
            }

            return View(documents);
        }

        // GET: Documents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Documents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Type,InsertDate,Description,TotalPrice,TotalCount,Payment,User")] Documents documents)
        {
            if (ModelState.IsValid)
            {
                _context.Add(documents);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(documents);
        }

        // GET: Documents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Documents == null)
            {
                return NotFound();
            }

            var documents = await _context.Documents.FindAsync(id);
            if (documents == null)
            {
                return NotFound();
            }
            return View(documents);
        }

        // POST: Documents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Type,InsertDate,Description,TotalPrice,TotalCount,Payment,User")] Documents documents)
        {
            if (id != documents.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(documents);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DocumentsExists(documents.Id))
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
            return View(documents);
        }

        // GET: Documents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Documents == null)
            {
                return NotFound();
            }

            var documents = await _context.Documents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (documents == null)
            {
                return NotFound();
            }

            return View(documents);
        }

        // POST: Documents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Documents == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Documents'  is null.");
            }
            var documents = await _context.Documents.FindAsync(id);
            if (documents != null)
            {
                _context.Documents.Remove(documents);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DocumentsExists(int id)
        {
          return (_context.Documents?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
