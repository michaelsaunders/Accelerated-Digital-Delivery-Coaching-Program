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
    public class ProgramIncrementGoalsController : Controller
    {
        private readonly AddDBContext _context;

        public ProgramIncrementGoalsController(AddDBContext context)
        {
            _context = context;
        }

        // GET: ProgramIncrementGoals
        public async Task<IActionResult> Index()
        {
            var addDBContext = _context.ProgramIncrementGoal.Include(p => p.ProgramIncrement);
            return View(await addDBContext.ToListAsync());
        }

        // GET: ProgramIncrementGoals/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programIncrementGoal = await _context.ProgramIncrementGoal
                .Include(p => p.ProgramIncrement)
                .FirstOrDefaultAsync(m => m.ProgramIncrementGoalID == id);
            if (programIncrementGoal == null)
            {
                return NotFound();
            }

            return View(programIncrementGoal);
        }

        // GET: ProgramIncrementGoals/Create
        public IActionResult Create()
        {
            ViewData["ProgramIncrementID"] = new SelectList(_context.ProgramIncrements, "ProgramIncrementID", "ProgramIncrementID");
            return View();
        }

        // POST: ProgramIncrementGoals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProgramIncrementGoalID,Goal,Measure,Specific,Measurable,Achievable,Realistic,Timebound,TiedToOKR,TeamID,BusinessValue,AcheivedValue,CommittedGoal,FistOfFive,CurrentStatus,ProgramIncrementID")] ProgramIncrementGoal programIncrementGoal)
        {
            if (ModelState.IsValid)
            {
                programIncrementGoal.ProgramIncrementGoalID = Guid.NewGuid();
                _context.Add(programIncrementGoal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProgramIncrementID"] = new SelectList(_context.ProgramIncrements, "ProgramIncrementID", "ProgramIncrementID", programIncrementGoal.ProgramIncrementID);
            return View(programIncrementGoal);
        }

        // GET: ProgramIncrementGoals/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programIncrementGoal = await _context.ProgramIncrementGoal.FindAsync(id);
            if (programIncrementGoal == null)
            {
                return NotFound();
            }
            ViewData["ProgramIncrementID"] = new SelectList(_context.ProgramIncrements, "ProgramIncrementID", "ProgramIncrementID", programIncrementGoal.ProgramIncrementID);
            return View(programIncrementGoal);
        }

        // POST: ProgramIncrementGoals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ProgramIncrementGoalID,Goal,Measure,Specific,Measurable,Achievable,Realistic,Timebound,TiedToOKR,TeamID,BusinessValue,AcheivedValue,CommittedGoal,FistOfFive,CurrentStatus,ProgramIncrementID")] ProgramIncrementGoal programIncrementGoal)
        {
            if (id != programIncrementGoal.ProgramIncrementGoalID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(programIncrementGoal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProgramIncrementGoalExists(programIncrementGoal.ProgramIncrementGoalID))
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
            ViewData["ProgramIncrementID"] = new SelectList(_context.ProgramIncrements, "ProgramIncrementID", "ProgramIncrementID", programIncrementGoal.ProgramIncrementID);
            return View(programIncrementGoal);
        }

        // GET: ProgramIncrementGoals/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programIncrementGoal = await _context.ProgramIncrementGoal
                .Include(p => p.ProgramIncrement)
                .FirstOrDefaultAsync(m => m.ProgramIncrementGoalID == id);
            if (programIncrementGoal == null)
            {
                return NotFound();
            }

            return View(programIncrementGoal);
        }

        // POST: ProgramIncrementGoals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var programIncrementGoal = await _context.ProgramIncrementGoal.FindAsync(id);
            _context.ProgramIncrementGoal.Remove(programIncrementGoal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProgramIncrementGoalExists(Guid id)
        {
            return _context.ProgramIncrementGoal.Any(e => e.ProgramIncrementGoalID == id);
        }
    }
}
