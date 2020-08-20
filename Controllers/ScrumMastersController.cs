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
    public class ScrumMastersController : Controller
    {
        private readonly AddDBContext _context;

        public ScrumMastersController(AddDBContext context)
        {
            _context = context;
        }

        // GET: ScrumMasters
        public async Task<IActionResult> Index()
        {
            var addDBContext = _context.ScrumMaster.Include(s => s.Person);
            return View(await addDBContext.ToListAsync());
        }

        // GET: ScrumMasters/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scrumMaster = await _context.ScrumMaster
                .Include(s => s.Person)
                .FirstOrDefaultAsync(m => m.ScrumMasterID == id);
            if (scrumMaster == null)
            {
                return NotFound();
            }

            return View(scrumMaster);
        }

        // GET: ScrumMasters/Create
        public IActionResult Create()
        {
            ViewData["PersonID"] = new SelectList(_context.Persons, "PersonID", "PersonsName");
            return View();
        }

        // POST: ScrumMasters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ScrumMasterID,PersonID,Name,Coaching,Velocity,TeamHappiness,Quality,ProcessEfficiency,BusinessValuePerStoryPoint,NextAppointment,PersonalImprovement")] ScrumMaster scrumMaster)
        {
            if (ModelState.IsValid)
            {
                scrumMaster.ScrumMasterID = Guid.NewGuid();
                _context.Add(scrumMaster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PersonID"] = new SelectList(_context.Persons, "PersonID", "PersonsName", scrumMaster.PersonID);
            return View(scrumMaster);
        }

        // GET: ScrumMasters/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scrumMaster = await _context.ScrumMaster.FindAsync(id);
            if (scrumMaster == null)
            {
                return NotFound();
            }
            ViewData["PersonID"] = new SelectList(_context.Persons, "PersonID", "PersonsName", scrumMaster.PersonID);
            return View(scrumMaster);
        }

        // POST: ScrumMasters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ScrumMasterID,PersonID,Name,Coaching,Velocity,TeamHappiness,Quality,ProcessEfficiency,BusinessValuePerStoryPoint,NextAppointment,PersonalImprovement")] ScrumMaster scrumMaster)
        {
            if (id != scrumMaster.ScrumMasterID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(scrumMaster);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScrumMasterExists(scrumMaster.ScrumMasterID))
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
            ViewData["PersonID"] = new SelectList(_context.Persons, "PersonID", "PersonsName", scrumMaster.PersonID);
            return View(scrumMaster);
        }

        // GET: ScrumMasters/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scrumMaster = await _context.ScrumMaster
                .Include(s => s.Person)
                .FirstOrDefaultAsync(m => m.ScrumMasterID == id);
            if (scrumMaster == null)
            {
                return NotFound();
            }

            return View(scrumMaster);
        }

        // POST: ScrumMasters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var scrumMaster = await _context.ScrumMaster.FindAsync(id);
            _context.ScrumMaster.Remove(scrumMaster);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScrumMasterExists(Guid id)
        {
            return _context.ScrumMaster.Any(e => e.ScrumMasterID == id);
        }
    }
}
