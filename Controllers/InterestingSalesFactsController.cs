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
    public class InterestingSalesFactsController : Controller
    {
        private readonly AddDBContext _context;

        public InterestingSalesFactsController(AddDBContext context)
        {
            _context = context;
        }

        // GET: InterestingSalesFacts
        public async Task<IActionResult> Index()
        {
            return View(await _context.InterestingSalesFacts.ToListAsync());
        }

        // GET: InterestingSalesFacts/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interestingSalesFacts = await _context.InterestingSalesFacts
                .FirstOrDefaultAsync(m => m.InterestingSalesFactsID == id);
            if (interestingSalesFacts == null)
            {
                return NotFound();
            }

            return View(interestingSalesFacts);
        }

        // GET: InterestingSalesFacts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: InterestingSalesFacts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InterestingSalesFactsID,Fact")] InterestingSalesFacts interestingSalesFacts)
        {
            if (ModelState.IsValid)
            {
                interestingSalesFacts.InterestingSalesFactsID = Guid.NewGuid();
                _context.Add(interestingSalesFacts);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(interestingSalesFacts);
        }

        // GET: InterestingSalesFacts/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interestingSalesFacts = await _context.InterestingSalesFacts.FindAsync(id);
            if (interestingSalesFacts == null)
            {
                return NotFound();
            }
            return View(interestingSalesFacts);
        }

        // POST: InterestingSalesFacts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("InterestingSalesFactsID,Fact")] InterestingSalesFacts interestingSalesFacts)
        {
            if (id != interestingSalesFacts.InterestingSalesFactsID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(interestingSalesFacts);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InterestingSalesFactsExists(interestingSalesFacts.InterestingSalesFactsID))
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
            return View(interestingSalesFacts);
        }

        // GET: InterestingSalesFacts/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interestingSalesFacts = await _context.InterestingSalesFacts
                .FirstOrDefaultAsync(m => m.InterestingSalesFactsID == id);
            if (interestingSalesFacts == null)
            {
                return NotFound();
            }

            return View(interestingSalesFacts);
        }

        // POST: InterestingSalesFacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var interestingSalesFacts = await _context.InterestingSalesFacts.FindAsync(id);
            _context.InterestingSalesFacts.Remove(interestingSalesFacts);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InterestingSalesFactsExists(Guid id)
        {
            return _context.InterestingSalesFacts.Any(e => e.InterestingSalesFactsID == id);
        }
    }
}
