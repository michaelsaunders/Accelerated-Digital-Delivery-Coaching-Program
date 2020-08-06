using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Accelerated_Digital_Delivery_Coaching_Program.Models;

namespace Accelerated_Digital_Delivery_Coaching_Program
{
    public class IterationGoalsController : Controller
    {
        private readonly AddDBContext _context;

        public IterationGoalsController(AddDBContext context)
        {
            _context = context;
        }

        // GET: IterationGoals
        public async Task<IActionResult> Index()
        {
            return View(await _context.IterationGoal.ToListAsync());
        }

        // GET: IterationGoals/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iterationGoal = await _context.IterationGoal
                .FirstOrDefaultAsync(m => m.IterationGoalID == id);
            if (iterationGoal == null)
            {
                return NotFound();
            }

            return View(iterationGoal);
        }

        // GET: IterationGoals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: IterationGoals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IterationGoalID,Goal,Specific,Measurable,Achievable,Realistic,Timebound,TiedToOKR,FistOfFive,CurrentStatus")] IterationGoal iterationGoal)
        {
            if (ModelState.IsValid)
            {
                iterationGoal.IterationGoalID = Guid.NewGuid();
                _context.Add(iterationGoal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(iterationGoal);
        }

        // GET: IterationGoals/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iterationGoal = await _context.IterationGoal.FindAsync(id);
            if (iterationGoal == null)
            {
                return NotFound();
            }
            return View(iterationGoal);
        }

        // POST: IterationGoals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("IterationGoalID,Goal,Specific,Measurable,Achievable,Realistic,Timebound,TiedToOKR,FistOfFive,CurrentStatus")] IterationGoal iterationGoal)
        {
            if (id != iterationGoal.IterationGoalID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(iterationGoal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IterationGoalExists(iterationGoal.IterationGoalID))
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
            return View(iterationGoal);
        }

        // GET: IterationGoals/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iterationGoal = await _context.IterationGoal
                .FirstOrDefaultAsync(m => m.IterationGoalID == id);
            if (iterationGoal == null)
            {
                return NotFound();
            }

            return View(iterationGoal);
        }

        // POST: IterationGoals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var iterationGoal = await _context.IterationGoal.FindAsync(id);
            _context.IterationGoal.Remove(iterationGoal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IterationGoalExists(Guid id)
        {
            return _context.IterationGoal.Any(e => e.IterationGoalID == id);
        }
    }
}
