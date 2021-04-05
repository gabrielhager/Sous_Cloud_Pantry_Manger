using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sous_Cloud_Pantry.Models;

namespace Sous_Cloud_Pantry.Controllers
{
    public class PantriesController : Controller
    {
        private readonly SousDataContext _context;

        public PantriesController(SousDataContext context)
        {
            _context = context;
        }

        // GET: Pantries
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pantries.ToListAsync());
        }

        // GET: Pantries/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pantry = await _context.Pantries
                .FirstOrDefaultAsync(m => m.PantryLocation == id);
            if (pantry == null)
            {
                return NotFound();
            }

            return View(pantry);
        }

        // GET: Pantries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pantries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,PantryLocation")] Pantry pantry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pantry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pantry);
        }

        // GET: Pantries/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pantry = await _context.Pantries.FindAsync(id);
            if (pantry == null)
            {
                return NotFound();
            }
            return View(pantry);
        }

        // POST: Pantries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UserId,PantryLocation")] Pantry pantry)
        {
            if (id != pantry.PantryLocation)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pantry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PantryExists(pantry.PantryLocation))
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
            return View(pantry);
        }

        // GET: Pantries/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pantry = await _context.Pantries
                .FirstOrDefaultAsync(m => m.PantryLocation == id);
            if (pantry == null)
            {
                return NotFound();
            }

            return View(pantry);
        }

        // POST: Pantries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var pantry = await _context.Pantries.FindAsync(id);
            _context.Pantries.Remove(pantry);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PantryExists(string id)
        {
            return _context.Pantries.Any(e => e.PantryLocation == id);
        }
    }
}
