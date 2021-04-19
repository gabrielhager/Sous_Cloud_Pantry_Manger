using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sous_Cloud_Pantry.models;

namespace Sous_Cloud_Pantry.Controllers
{
    public class GroceryListsController : Controller
    {
        private readonly SousKitchenPantryDBContext _context;

        public GroceryListsController(SousKitchenPantryDBContext context)
        {
            _context = context;
        }

        // GET: GroceryLists
        public async Task<IActionResult> Index()
        {
            var sousKitchenPantryDBContext = _context.GroceryLists.Include(g => g.User);
            return View(await sousKitchenPantryDBContext.ToListAsync());
        }

        // GET: GroceryLists/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groceryList = await _context.GroceryLists
                .Include(g => g.User)
                .FirstOrDefaultAsync(m => m.ListItem == id);
            if (groceryList == null)
            {
                return NotFound();
            }

            return View(groceryList);
        }

        // GET: GroceryLists/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.UserTables, "UserId", "UserId");
            return View();
        }

        // POST: GroceryLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,ListItem")] GroceryList groceryList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(groceryList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.UserTables, "UserId", "UserId", groceryList.UserId);
            return View(groceryList);
        }

        // GET: GroceryLists/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groceryList = await _context.GroceryLists.FindAsync(id);
            if (groceryList == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.UserTables, "UserId", "UserId", groceryList.UserId);
            return View(groceryList);
        }

        // POST: GroceryLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UserId,ListItem")] GroceryList groceryList)
        {
            if (id != groceryList.ListItem)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(groceryList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GroceryListExists(groceryList.ListItem))
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
            ViewData["UserId"] = new SelectList(_context.UserTables, "UserId", "UserId", groceryList.UserId);
            return View(groceryList);
        }

        // GET: GroceryLists/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groceryList = await _context.GroceryLists
                .Include(g => g.User)
                .FirstOrDefaultAsync(m => m.ListItem == id);
            if (groceryList == null)
            {
                return NotFound();
            }

            return View(groceryList);
        }

        // POST: GroceryLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var groceryList = await _context.GroceryLists.FindAsync(id);
            _context.GroceryLists.Remove(groceryList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GroceryListExists(string id)
        {
            return _context.GroceryLists.Any(e => e.ListItem == id);
        }
    }
}
