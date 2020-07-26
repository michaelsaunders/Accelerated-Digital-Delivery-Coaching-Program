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
    public class ProgramIncrementsController : Controller
    {
        private readonly AddDBContext _context;

        public ProgramIncrementsController(AddDBContext context)
        {
            _context = context;
        }

        // GET: ProgramIncrements
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProgramIncrements.ToListAsync());
        }

        // GET: ProgramIncrements/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programIncrement = await _context.ProgramIncrements
                .FirstOrDefaultAsync(m => m.ProgramIncrementID == id);
            if (programIncrement == null)
            {
                return NotFound();
            }

            return View(programIncrement);
        }

        // GET: ProgramIncrements/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProgramIncrements/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProgramIncrementID,IncrementID,StartDate,EndDate")] ProgramIncrement programIncrement)
        {
            if (ModelState.IsValid)
            {
                programIncrement.ProgramIncrementID = Guid.NewGuid();
                _context.Add(programIncrement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(programIncrement);
        }

        // GET: ProgramIncrements/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programIncrement = await _context.ProgramIncrements.FindAsync(id);
            if (programIncrement == null)
            {
                return NotFound();
            }
            return View(programIncrement);
        }

        // POST: ProgramIncrements/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ProgramIncrementID,IncrementID,StartDate,EndDate")] ProgramIncrement programIncrement)
        {
            if (id != programIncrement.ProgramIncrementID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(programIncrement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProgramIncrementExists(programIncrement.ProgramIncrementID))
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
            return View(programIncrement);
        }

        // GET: ProgramIncrements/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programIncrement = await _context.ProgramIncrements
                .FirstOrDefaultAsync(m => m.ProgramIncrementID == id);
            if (programIncrement == null)
            {
                return NotFound();
            }

            return View(programIncrement);
        }

        // POST: ProgramIncrements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var programIncrement = await _context.ProgramIncrements.FindAsync(id);
            _context.ProgramIncrements.Remove(programIncrement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProgramIncrementExists(Guid id)
        {
            return _context.ProgramIncrements.Any(e => e.ProgramIncrementID == id);
        }
    }
}
