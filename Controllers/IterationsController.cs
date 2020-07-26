using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Accelerated_Digital_Delivery_Coaching_Program.Models;

namespace Accelerated_Digital_Delivery_Coaching_Program.Controllers
{
    public class IterationsController : Controller
    {
        private readonly AddDBContext _context;

        public IterationsController(AddDBContext context)
        {
            _context = context;
        }

        // GET: Iterations
        public async Task<IActionResult> Index()
        {
            var addDBContext = _context.Iterations.Include(i => i.IterationGoal).Include(i => i.Team);
            return View(await addDBContext.ToListAsync());
        }

        // GET: Iterations/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iteration = await _context.Iterations
                .Include(i => i.IterationGoal)
                .Include(i => i.Team)
                .FirstOrDefaultAsync(m => m.IterationID == id);
            if (iteration == null)
            {
                return NotFound();
            }

            return View(iteration);
        }

        // GET: Iterations/Create
        public IActionResult Create()
        {
            ViewData["IterationGoalID"] = new SelectList(_context.IterationGoal, "IterationGoalID", "IterationGoalID");
            ViewData["TeamID"] = new SelectList(_context.Teams, "TeamID", "TeamID");
            return View();
        }

        // POST: Iterations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IterationID,IterationName,StartDate,StopDate,TeamID,CompletedWork,CommittedWork,IterationGoalID")] Iteration iteration)
        {
            if (ModelState.IsValid)
            {
                iteration.IterationID = Guid.NewGuid();
                _context.Add(iteration);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IterationGoalID"] = new SelectList(_context.IterationGoal, "IterationGoalID", "IterationGoalID", iteration.IterationGoalID);
            ViewData["TeamID"] = new SelectList(_context.Teams, "TeamID", "TeamID", iteration.TeamID);
            return View(iteration);
        }

        // GET: Iterations/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iteration = await _context.Iterations.FindAsync(id);
            if (iteration == null)
            {
                return NotFound();
            }
            ViewData["IterationGoalID"] = new SelectList(_context.IterationGoal, "IterationGoalID", "IterationGoalID", iteration.IterationGoalID);
            ViewData["TeamID"] = new SelectList(_context.Teams, "TeamID", "TeamID", iteration.TeamID);
            return View(iteration);
        }

        // POST: Iterations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("IterationID,IterationName,StartDate,StopDate,TeamID,CompletedWork,CommittedWork,IterationGoalID")] Iteration iteration)
        {
            if (id != iteration.IterationID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(iteration);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IterationExists(iteration.IterationID))
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
            ViewData["IterationGoalID"] = new SelectList(_context.IterationGoal, "IterationGoalID", "IterationGoalID", iteration.IterationGoalID);
            ViewData["TeamID"] = new SelectList(_context.Teams, "TeamID", "TeamID", iteration.TeamID);
            return View(iteration);
        }

        // GET: Iterations/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iteration = await _context.Iterations
                .Include(i => i.IterationGoal)
                .Include(i => i.Team)
                .FirstOrDefaultAsync(m => m.IterationID == id);
            if (iteration == null)
            {
                return NotFound();
            }

            return View(iteration);
        }

        // POST: Iterations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var iteration = await _context.Iterations.FindAsync(id);
            _context.Iterations.Remove(iteration);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IterationExists(Guid id)
        {
            return _context.Iterations.Any(e => e.IterationID == id);
        }
    }
}
