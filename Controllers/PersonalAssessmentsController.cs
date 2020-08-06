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
    public class PersonalAssessmentsController : Controller
    {
        private readonly AddDBContext _context;

        public PersonalAssessmentsController(AddDBContext context)
        {
            _context = context;
        }

        // GET: PersonalAssessments
        public async Task<IActionResult> Index()
        {
            var addDBContext = _context.PersonalAssessment.Include(p => p.Person).Include(pat => pat.PersonalAssessmentTemplate);
            return View(await addDBContext.ToListAsync());
        }

        // GET: PersonalAssessments/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalAssessment = await _context.PersonalAssessment
                .Include(p => p.Person).Include(pat => pat.PersonalAssessmentTemplate)
                .FirstOrDefaultAsync(m => m.PersonalAssessmentID == id);
            if (personalAssessment == null)
            {
                return NotFound();
            }

            return View(personalAssessment);
        }


        // GET: PersonalAssessments/Create
        public IActionResult CreateWithPersonID(long id)
        {
            PersonalAssessment personalAssessment = new PersonalAssessment();
            personalAssessment.PersonID = id;
            ViewData["PersonalAssessmentTemplateID"] = new SelectList(_context.PersonalAssessmentTemplate, "PersonalAssessmentTemplateID", "PersonalAssessmentTemplateName", personalAssessment.PersonalAssessmentTemplateID); ;
            ViewData["PersonID"] = new SelectList(_context.Persons, "PersonID", "PersonID");
            return View(personalAssessment);
        }

        // GET: PersonalAssessments/Create
        public IActionResult Create()
        {
            ViewData["PersonID"] = new SelectList(_context.Persons, "PersonID", "PersonID");
            return View();
        }

        // POST: PersonalAssessments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonalAssessmentID,PersonID,AssessmentName,DateOfAssessment,AreaCoaching,NotesForAssessment,SummaryResult,NextAsessmentDate")] PersonalAssessment personalAssessment)
        {
            if (ModelState.IsValid)
            {
                personalAssessment.PersonalAssessmentID = Guid.NewGuid();
                _context.Add(personalAssessment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PersonID"] = new SelectList(_context.Persons, "PersonID", "PersonID", personalAssessment.PersonID);
            return View(personalAssessment);
        }

        // POST: PersonalAssessments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateWithID([Bind("PersonalAssessmentID,PersonID,AssessmentName,DateOfAssessment,AreaCoaching,NotesForAssessment,SummaryResult,NextAsessmentDate")] PersonalAssessment personalAssessment)
        {
            if (ModelState.IsValid)
            {
                personalAssessment.PersonalAssessmentID = Guid.NewGuid();
                _context.Add(personalAssessment);
                await _context.SaveChangesAsync();
                return RedirectToAction("PersonalCoachingDetails","People",new { id = personalAssessment.PersonID  });
            }
            ViewData["PersonalAssessmentTemplateID"] = new SelectList(_context.PersonalAssessmentTemplate, "PersonalAssessmentTemplateID", "PersonalAssessmentTemplateName", personalAssessment.PersonalAssessmentTemplateID);
            ViewData["PersonID"] = new SelectList(_context.Persons, "PersonID", "PersonID", personalAssessment.PersonID);
            return View(personalAssessment);
        }


        // GET: PersonalAssessments/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalAssessment = await _context.PersonalAssessment.FindAsync(id);
            if (personalAssessment == null)
            {
                return NotFound();
            }
            ViewData["PersonID"] = new SelectList(_context.Persons, "PersonID", "PersonID", personalAssessment.PersonID);
            return View(personalAssessment);
        }

        // GET: PersonalAssessments/EditWithPersonID/5
        public async Task<IActionResult> EditWithPersonID(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalAssessment = await _context.PersonalAssessment.FindAsync(id);
            if (personalAssessment == null)
            {
                return NotFound();
            }
            ViewData["PersonalAssessmentTemplateID"] = new SelectList(_context.PersonalAssessmentTemplate, "PersonalAssessmentTemplateID", "PersonalAssessmentTemplateName", personalAssessment.PersonalAssessmentTemplateID);
            ViewData["PersonID"] = new SelectList(_context.Persons, "PersonID", "PersonID", personalAssessment.PersonID);
            return View(personalAssessment);
        }

        // POST: PersonalAssessments/EditWithPersonID/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditWithPersonID(Guid id, [Bind("PersonalAssessmentID,PersonalAssessmentTemplateID,PersonID,AssessmentName,DateOfAssessment,AreaCoaching,NotesForAssessment,SummaryResult,NextAsessmentDate")] PersonalAssessment personalAssessment)
        {
            if (id != personalAssessment.PersonalAssessmentID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personalAssessment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonalAssessmentExists(personalAssessment.PersonalAssessmentID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("PersonalCoachingDetails","People", new { id = personalAssessment.PersonID });
            }
            ViewData["PersonID"] = new SelectList(_context.Persons, "PersonID", "PersonID", personalAssessment.PersonID);
            return View(personalAssessment);
        }

        // GET: PersonalAssessments/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalAssessment = await _context.PersonalAssessment
                .Include(p => p.Person)
                .FirstOrDefaultAsync(m => m.PersonalAssessmentID == id);
            if (personalAssessment == null)
            {
                return NotFound();
            }

            return View(personalAssessment);
        }

        // POST: PersonalAssessments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var personalAssessment = await _context.PersonalAssessment.FindAsync(id);
            _context.PersonalAssessment.Remove(personalAssessment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonalAssessmentExists(Guid id)
        {
            return _context.PersonalAssessment.Any(e => e.PersonalAssessmentID == id);
        }
    }
}
