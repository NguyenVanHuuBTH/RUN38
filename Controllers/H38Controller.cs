using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HUMG.Models;

namespace HUMG.Controllers
{
    public class H38Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public H38Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: H38
        public async Task<IActionResult> Index()
        {
              return _context.H38 != null ? 
                          View(await _context.H38.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.H38'  is null.");
        }

        // GET: H38/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.H38 == null)
            {
                return NotFound();
            }

            var h38 = await _context.H38
                .FirstOrDefaultAsync(m => m.H38ID == id);
            if (h38 == null)
            {
                return NotFound();
            }

            return View(h38);
        }

        // GET: H38/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: H38/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("H38ID,H38Name")] H38 h38)
        {
            if (ModelState.IsValid)
            {
                _context.Add(h38);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(h38);
        }

        // GET: H38/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.H38 == null)
            {
                return NotFound();
            }

            var h38 = await _context.H38.FindAsync(id);
            if (h38 == null)
            {
                return NotFound();
            }
            return View(h38);
        }

        // POST: H38/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("H38ID,H38Name")] H38 h38)
        {
            if (id != h38.H38ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(h38);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!H38Exists(h38.H38ID))
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
            return View(h38);
        }

        // GET: H38/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.H38 == null)
            {
                return NotFound();
            }

            var h38 = await _context.H38
                .FirstOrDefaultAsync(m => m.H38ID == id);
            if (h38 == null)
            {
                return NotFound();
            }

            return View(h38);
        }

        // POST: H38/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.H38 == null)
            {
                return Problem("Entity set 'ApplicationDbContext.H38'  is null.");
            }
            var h38 = await _context.H38.FindAsync(id);
            if (h38 != null)
            {
                _context.H38.Remove(h38);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool H38Exists(string id)
        {
          return (_context.H38?.Any(e => e.H38ID == id)).GetValueOrDefault();
        }
    }
}
