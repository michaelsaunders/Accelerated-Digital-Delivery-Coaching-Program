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
    public class PatternAssessmentsController : Controller
    {
        private readonly AddDBContext _context;

        public PatternAssessmentsController(AddDBContext context)
        {
            _context = context;
        }

        // GET: PatternAssessments
        public async Task<IActionResult> Index()
        {
            return View(await _context.PatternAssessment.ToListAsync());
        }

        // GET: PatternAssessments/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patternAssessment = await _context.PatternAssessment
                .FirstOrDefaultAsync(m => m.PatternAssessmentID == id);
            if (patternAssessment == null)
            {
                return NotFound();
            }

            return View(patternAssessment);
        }

        // GET: PatternAssessments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PatternAssessments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PatternAssessmentID,TeamID,PatternID,Implemented,WithIntent,RatingOfAssessment,Notes,AssessmentDate,NextAssessmentDate,FollowUpCompleted,RecordActive")] PatternAssessment patternAssessment)
        {
            if (ModelState.IsValid)
            {
                patternAssessment.PatternAssessmentID = Guid.NewGuid();
                _context.Add(patternAssessment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(patternAssessment);
        }

        // GET: PatternAssessments/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patternAssessment = await _context.PatternAssessment.FindAsync(id);
            if (patternAssessment == null)
            {
                return NotFound();
            }
            return View(patternAssessment);
        }

        // POST: PatternAssessments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("PatternAssessmentID,TeamID,PatternID,Implemented,WithIntent,RatingOfAssessment,Notes,AssessmentDate,NextAssessmentDate,FollowUpCompleted,RecordActive")] PatternAssessment patternAssessment)
        {
            if (id != patternAssessment.PatternAssessmentID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(patternAssessment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PatternAssessmentExists(patternAssessment.PatternAssessmentID))
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
            return View(patternAssessment);
        }

        // GET: PatternAssessments/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patternAssessment = await _context.PatternAssessment
                .FirstOrDefaultAsync(m => m.PatternAssessmentID == id);
            if (patternAssessment == null)
            {
                return NotFound();
            }

            return View(patternAssessment);
        }

        // POST: PatternAssessments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var patternAssessment = await _context.PatternAssessment.FindAsync(id);
            _context.PatternAssessment.Remove(patternAssessment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PatternAssessmentExists(Guid id)
        {
            return _context.PatternAssessment.Any(e => e.PatternAssessmentID == id);
        }
    }
}
