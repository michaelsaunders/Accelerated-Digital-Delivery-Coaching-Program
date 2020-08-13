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
    public class TeamOfTeamIterationsController : Controller
    {
        private readonly AddDBContext _context;

        public TeamOfTeamIterationsController(AddDBContext context)
        {
            _context = context;
        }

        // GET: TeamOfTeamIterations
        public async Task<IActionResult> Index()
        {
            var addDBContext = _context.TeamOfTeamIteration.Include(t => t.ProgramIncrement).OrderBy(b=>b.TeamOfTeamIterationName);
            return View(await addDBContext.ToListAsync());
        }

        // GET: TeamOfTeamIterations/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamOfTeamIteration = await _context.TeamOfTeamIteration
                .Include(t => t.ProgramIncrement)
                .FirstOrDefaultAsync(m => m.TeamOfTeamIterationID == id);
            if (teamOfTeamIteration == null)
            {
                return NotFound();
            }

            return View(teamOfTeamIteration);
        }

        // GET: TeamOfTeamIterations/Create
        public IActionResult Create()
        {
            ViewData["ProgramIncrementID"] = new SelectList(_context.ProgramIncrements, "ProgramIncrementID", "IncrementID");
            ViewData["TeamOfTeamID"] = new SelectList(_context.TeamOfTeams, "TeamOfTeamID", "TeamOfTeamsName");
            return View();
        }

        // POST: TeamOfTeamIterations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TeamOfTeamIterationID,TeamOfTeamID,TeamOfTeamIterationName,StartDate,StopDate,ProgramIncrementID,YesterdaysWeather,IncrementCommittedVelocity,IncrementDeliveredVelocity")] TeamOfTeamIteration teamOfTeamIteration)
        {
            if (ModelState.IsValid)
            {
                teamOfTeamIteration.TeamOfTeamIterationID = Guid.NewGuid();
                _context.Add(teamOfTeamIteration);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProgramIncrementID"] = new SelectList(_context.ProgramIncrements, "ProgramIncrementID", "IncrementID", teamOfTeamIteration.ProgramIncrementID);
            return View(teamOfTeamIteration);
        }

        // GET: TeamOfTeamIterations/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamOfTeamIteration = await _context.TeamOfTeamIteration.FindAsync(id);
            if (teamOfTeamIteration == null)
            {
                return NotFound();
            }
            ViewData["TeamOfTeamID"] = new SelectList(_context.TeamOfTeams, "TeamOfTeamID", "TeamOfTeamsName");
            ViewData["ProgramIncrementID"] = new SelectList(_context.ProgramIncrements, "ProgramIncrementID", "IncrementID", teamOfTeamIteration.ProgramIncrementID);
            return View(teamOfTeamIteration);
        }

        // POST: TeamOfTeamIterations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("TeamOfTeamIterationID,TeamOfTeamID,TeamOfTeamIterationName,StartDate,StopDate,ProgramIncrementID,YesterdaysWeather,IncrementCommittedVelocity,IncrementDeliveredVelocity")] TeamOfTeamIteration teamOfTeamIteration)
        {
            if (id != teamOfTeamIteration.TeamOfTeamIterationID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teamOfTeamIteration);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeamOfTeamIterationExists(teamOfTeamIteration.TeamOfTeamIterationID))
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
            ViewData["ProgramIncrementID"] = new SelectList(_context.ProgramIncrements, "ProgramIncrementID", "IncrementID", teamOfTeamIteration.ProgramIncrementID);
            return View(teamOfTeamIteration);
        }

        // GET: TeamOfTeamIterations/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamOfTeamIteration = await _context.TeamOfTeamIteration
                .Include(t => t.ProgramIncrement)
                .FirstOrDefaultAsync(m => m.TeamOfTeamIterationID == id);
            if (teamOfTeamIteration == null)
            {
                return NotFound();
            }

            return View(teamOfTeamIteration);
        }

        // POST: TeamOfTeamIterations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var teamOfTeamIteration = await _context.TeamOfTeamIteration.FindAsync(id);
            _context.TeamOfTeamIteration.Remove(teamOfTeamIteration);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeamOfTeamIterationExists(Guid id)
        {
            return _context.TeamOfTeamIteration.Any(e => e.TeamOfTeamIterationID == id);
        }
    }
}
