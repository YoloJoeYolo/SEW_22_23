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
    public class TaskController : Controller
    {
        private readonly Hue06Context _context;

        public TaskController(Hue06Context context)
        {
            _context = context;
        }

        // GET: Task
        public async Task<IActionResult> Index()
        {
            var hue06Context = _context.Tasks.Include(t => t.PriorityNavigation).Include(t => t.StatusNavigation);
            return View(await hue06Context.ToListAsync());
        }

        // GET: Task/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.Tasks == null)
            {
                return NotFound();
            }

            var task = await _context.Tasks
                .Include(t => t.PriorityNavigation)
                .Include(t => t.StatusNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (task == null)
            {
                return NotFound();
            }

            return View(task);
        }

        // GET: Task/Create
        public IActionResult Create()
        {
            ViewData["Priority"] = new SelectList(_context.Priorities, "Id", "Priority1");
            ViewData["Status"] = new SelectList(_context.Statuses, "Id", "Status1");
            return View();
        }

        // POST: Task/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Summary,Description,CreationDate,DueDate,Priority,Status")] ToDoShared.Task task)
        {
            if (ModelState.IsValid)
            {
                _context.Add(task);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Priority"] = new SelectList(_context.Priorities, "Id", "Priority1", task.Priority);
            ViewData["Status"] = new SelectList(_context.Statuses, "Id", "Status1", task.Status);
            return View(task);
        }

        // GET: Task/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.Tasks == null)
            {
                return NotFound();
            }

            var task = await _context.Tasks.FindAsync(id);
            if (task == null)
            {
                return NotFound();
            }
            ViewData["Priority"] = new SelectList(_context.Priorities, "Id", "Priority1", task.Priority);
            ViewData["Status"] = new SelectList(_context.Statuses, "Id", "Status1", task.Status);
            return View(task);
        }

        // POST: Task/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Summary,Description,CreationDate,DueDate,Priority,Status")] ToDoShared.Task task)
        {
            if (id != task.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(task);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaskExists(task.Id))
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
            ViewData["Priority"] = new SelectList(_context.Priorities, "Id", "Priority1", task.Priority);
            ViewData["Status"] = new SelectList(_context.Statuses, "Id", "Status1", task.Status);
            return View(task);
        }

        // GET: Task/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.Tasks == null)
            {
                return NotFound();
            }

            var task = await _context.Tasks
                .Include(t => t.PriorityNavigation)
                .Include(t => t.StatusNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (task == null)
            {
                return NotFound();
            }

            return View(task);
        }

        // POST: Task/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.Tasks == null)
            {
                return Problem("Entity set 'Hue06Context.Tasks'  is null.");
            }
            var task = await _context.Tasks.FindAsync(id);
            if (task != null)
            {
                _context.Tasks.Remove(task);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaskExists(long id)
        {
          return (_context.Tasks?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
