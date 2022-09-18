using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCWatches.Data;
using MVCWatches.Models;

namespace MVCWatches.Controllers
{
    public class WatchesController : Controller
    {
        private readonly MVCWatchesContext _context;

        public WatchesController(MVCWatchesContext context)
        {
            _context = context;
        }

        // GET: Watches
        public async Task<IActionResult> Index()
        {
            return View(await _context.Watches.ToListAsync());
        }

        // GET: Watches/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Watches == null)
            {
                return NotFound();
            }

            var watches = await _context.Watches
                .FirstOrDefaultAsync(m => m.IDWatch == id);
            if (watches == null)
            {
                return NotFound();
            }

            return View(watches);
        }

        // GET: Watches/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Watches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDWatch,Categoria,Nome,Marca,Valor,Cor,Ano")] Watches watches)
        {
            if (ModelState.IsValid)
            {
                _context.Add(watches);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(watches);
        }

        // GET: Watches/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Watches == null)
            {
                return NotFound();
            }

            var watches = await _context.Watches.FindAsync(id);
            if (watches == null)
            {
                return NotFound();
            }
            return View(watches);
        }

        // POST: Watches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDWatch,Categoria,Nome,Marca,Valor,Cor,Ano")] Watches watches)
        {
            if (id != watches.IDWatch)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(watches);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WatchesExists(watches.IDWatch))
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
            return View(watches);
        }

        // GET: Watches/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Watches == null)
            {
                return NotFound();
            }

            var watches = await _context.Watches
                .FirstOrDefaultAsync(m => m.IDWatch == id);
            if (watches == null)
            {
                return NotFound();
            }

            return View(watches);
        }

        // POST: Watches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Watches == null)
            {
                return Problem("Entity set 'MVCWatchesContext.Watches'  is null.");
            }
            var watches = await _context.Watches.FindAsync(id);
            if (watches != null)
            {
                _context.Watches.Remove(watches);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WatchesExists(int id)
        {
          return _context.Watches.Any(e => e.IDWatch == id);
        }
    }
}
