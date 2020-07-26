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
    public class TeamOfTeamsController : Controller
    {
        private readonly AddDBContext _context;

        public TeamOfTeamsController(AddDBContext context)
        {
            _context = context;
        }

        // GET: TeamOfTeams
        public async Task<IActionResult> Index()
        {
            return View(await _context.TeamOfTeams.ToListAsync());
        }

        // GET: TeamOfTeams/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamOfTeam = await _context.TeamOfTeams
                .FirstOrDefaultAsync(m => m.TeamOfTeamID == id);
            if (teamOfTeam == null)
            {
                return NotFound();
            }

            return View(teamOfTeam);
        }

        // GET: TeamOfTeams/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TeamOfTeams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TeamOfTeamID,TeamOfTeamsName")] TeamOfTeam teamOfTeam)
        {
            if (ModelState.IsValid)
            {
                teamOfTeam.TeamOfTeamID = Guid.NewGuid();
                _context.Add(teamOfTeam);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teamOfTeam);
        }

        // GET: TeamOfTeams/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamOfTeam = await _context.TeamOfTeams.FindAsync(id);
            if (teamOfTeam == null)
            {
                return NotFound();
            }
            return View(teamOfTeam);
        }

        // POST: TeamOfTeams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("TeamOfTeamID,TeamOfTeamsName")] TeamOfTeam teamOfTeam)
        {
            if (id != teamOfTeam.TeamOfTeamID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teamOfTeam);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeamOfTeamExists(teamOfTeam.TeamOfTeamID))
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
            return View(teamOfTeam);
        }

        // GET: TeamOfTeams/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamOfTeam = await _context.TeamOfTeams
                .FirstOrDefaultAsync(m => m.TeamOfTeamID == id);
            if (teamOfTeam == null)
            {
                return NotFound();
            }

            return View(teamOfTeam);
        }

        // POST: TeamOfTeams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var teamOfTeam = await _context.TeamOfTeams.FindAsync(id);
            _context.TeamOfTeams.Remove(teamOfTeam);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeamOfTeamExists(Guid id)
        {
            return _context.TeamOfTeams.Any(e => e.TeamOfTeamID == id);
        }
    }
}
