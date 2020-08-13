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
    public class EpicsController : Controller
    {
        private readonly AddDBContext _context;

        public EpicsController(AddDBContext context)
        {
            _context = context;
        }

        // GET: Epics
        public async Task<IActionResult> Index()
        {
            return View(await _context.Epic.ToListAsync());
        }

        // GET: Epics/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var epic = await _context.Epic
                .FirstOrDefaultAsync(m => m.EpicID == id);
            if (epic == null)
            {
                return NotFound();
            }

            return View(epic);
        }

        // GET: Epics/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Epics/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EpicID,EpicName,CustomerIdentifierID,EstimatedStoryPoints,ActualStoryPoints,TeamofTeamID,TeamID")] Epic epic)
        {
            if (ModelState.IsValid)
            {
                epic.EpicID = Guid.NewGuid();
                _context.Add(epic);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(epic);
        }

        // GET: Epics/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var epic = await _context.Epic.FindAsync(id);
            if (epic == null)
            {
                return NotFound();
            }
            return View(epic);
        }

        // POST: Epics/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("EpicID,EpicName,CustomerIdentifierID,EstimatedStoryPoints,ActualStoryPoints,TeamofTeamID,TeamID")] Epic epic)
        {
            if (id != epic.EpicID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(epic);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EpicExists(epic.EpicID))
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
            return View(epic);
        }

        // GET: Epics/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var epic = await _context.Epic
                .FirstOrDefaultAsync(m => m.EpicID == id);
            if (epic == null)
            {
                return NotFound();
            }

            return View(epic);
        }

        // POST: Epics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var epic = await _context.Epic.FindAsync(id);
            _context.Epic.Remove(epic);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EpicExists(Guid id)
        {
            return _context.Epic.Any(e => e.EpicID == id);
        }
    }
}
