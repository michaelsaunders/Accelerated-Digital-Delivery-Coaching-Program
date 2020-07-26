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
    public class TeamSprintsController : Controller
    {
        private readonly AddDBContext _context;

        public TeamSprintsController(AddDBContext context)
        {
            _context = context;
        }

        // GET: TeamSprints
        public async Task<IActionResult> Index()
        {
            return View(await _context.TeamSprint.ToListAsync());
        }

        // GET: TeamSprints/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamSprint = await _context.TeamSprint
                .FirstOrDefaultAsync(m => m.TeamSprintID == id);
            if (teamSprint == null)
            {
                return NotFound();
            }

            return View(teamSprint);
        }

        // GET: TeamSprints/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TeamSprints/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TeamSprintID,SprintID,TeamID")] TeamSprint teamSprint)
        {
            if (ModelState.IsValid)
            {
                teamSprint.TeamSprintID = Guid.NewGuid();
                _context.Add(teamSprint);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teamSprint);
        }

        // GET: TeamSprints/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamSprint = await _context.TeamSprint.FindAsync(id);
            if (teamSprint == null)
            {
                return NotFound();
            }
            return View(teamSprint);
        }

        // POST: TeamSprints/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("TeamSprintID,SprintID,TeamID")] TeamSprint teamSprint)
        {
            if (id != teamSprint.TeamSprintID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teamSprint);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeamSprintExists(teamSprint.TeamSprintID))
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
            return View(teamSprint);
        }

        // GET: TeamSprints/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamSprint = await _context.TeamSprint
                .FirstOrDefaultAsync(m => m.TeamSprintID == id);
            if (teamSprint == null)
            {
                return NotFound();
            }

            return View(teamSprint);
        }

        // POST: TeamSprints/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var teamSprint = await _context.TeamSprint.FindAsync(id);
            _context.TeamSprint.Remove(teamSprint);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeamSprintExists(Guid id)
        {
            return _context.TeamSprint.Any(e => e.TeamSprintID == id);
        }
    }
}
