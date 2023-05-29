using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ToDoShared;

namespace Hue06.Controllers
{
    public class PriorityController : Controller
    {
        private readonly Hue06Context _context;

        public PriorityController(Hue06Context context)
        {
            _context = context;
        }

        // GET: Priority
        public async Task<IActionResult> Index()
        {
              return _context.Priorities != null ? 
                          View(await _context.Priorities.ToListAsync()) :
                          Problem("Entity set 'Hue06Context.Priorities'  is null.");
        }

        // GET: Priority/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.Priorities == null)
            {
                return NotFound();
            }

            var priority = await _context.Priorities
                .FirstOrDefaultAsync(m => m.Id == id);
            if (priority == null)
            {
                return NotFound();
            }

            return View(priority);
        }

        // GET: Priority/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Priority/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Priority1")] Priority priority)
        {
            if (ModelState.IsValid)
            {
                _context.Add(priority);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(priority);
        }

        // GET: Priority/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.Priorities == null)
            {
                return NotFound();
            }

            var priority = await _context.Priorities.FindAsync(id);
            if (priority == null)
            {
                return NotFound();
            }
            return View(priority);
        }

        // POST: Priority/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Priority1")] Priority priority)
        {
            if (id != priority.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(priority);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PriorityExists(priority.Id))
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
            return View(priority);
        }

        // GET: Priority/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.Priorities == null)
            {
                return NotFound();
            }

            var priority = await _context.Priorities
                .FirstOrDefaultAsync(m => m.Id == id);
            if (priority == null)
            {
                return NotFound();
            }

            return View(priority);
        }

        // POST: Priority/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.Priorities == null)
            {
                return Problem("Entity set 'Hue06Context.Priorities'  is null.");
            }
            var priority = await _context.Priorities.FindAsync(id);
            if (priority != null)
            {
                _context.Priorities.Remove(priority);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PriorityExists(long id)
        {
          return (_context.Priorities?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
