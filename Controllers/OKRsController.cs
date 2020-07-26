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
    public class OKRsController : Controller
    {
        private readonly AddDBContext _context;

        public OKRsController(AddDBContext context)
        {
            _context = context;
        }

        // GET: OKRs
        public async Task<IActionResult> Index()
        {
            return View(await _context.OKRs.ToListAsync());
        }

        // GET: OKRs/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oKR = await _context.OKRs
                .FirstOrDefaultAsync(m => m.OkrID == id);
            if (oKR == null)
            {
                return NotFound();
            }

            return View(oKR);
        }

        // GET: OKRs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OKRs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OkrID,Objective,Measure1,Measure2,Measure3,Measure4,Measure5,MetricMeasure1,MetricMeasure2,MetricMeasure3,MetricMeasure4,MetricMeasure5,ConfidenceScoreMeasure1,ConfidenceScoreMeasure2,ConfidenceScoreMeasure3,ConfidenceScoreMeasure4,ConfidenceScoreMeasure5")] OKR oKR)
        {
            if (ModelState.IsValid)
            {
                oKR.OkrID = Guid.NewGuid();
                _context.Add(oKR);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(oKR);
        }

        // GET: OKRs/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oKR = await _context.OKRs.FindAsync(id);
            if (oKR == null)
            {
                return NotFound();
            }
            return View(oKR);
        }

        // POST: OKRs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("OkrID,Objective,Measure1,Measure2,Measure3,Measure4,Measure5,MetricMeasure1,MetricMeasure2,MetricMeasure3,MetricMeasure4,MetricMeasure5,ConfidenceScoreMeasure1,ConfidenceScoreMeasure2,ConfidenceScoreMeasure3,ConfidenceScoreMeasure4,ConfidenceScoreMeasure5")] OKR oKR)
        {
            if (id != oKR.OkrID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(oKR);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OKRExists(oKR.OkrID))
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
            return View(oKR);
        }

        // GET: OKRs/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oKR = await _context.OKRs
                .FirstOrDefaultAsync(m => m.OkrID == id);
            if (oKR == null)
            {
                return NotFound();
            }

            return View(oKR);
        }

        // POST: OKRs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var oKR = await _context.OKRs.FindAsync(id);
            _context.OKRs.Remove(oKR);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OKRExists(Guid id)
        {
            return _context.OKRs.Any(e => e.OkrID == id);
        }
    }
}
