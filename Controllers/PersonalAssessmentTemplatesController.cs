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
    public class PersonalAssessmentTemplatesController : Controller
    {
        private readonly AddDBContext _context;

        public PersonalAssessmentTemplatesController(AddDBContext context)
        {
            _context = context;
        }

        // GET: PersonalAssessmentTemplates
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonalAssessmentTemplate.ToListAsync());
        }

        // GET: PersonalAssessmentTemplates/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalAssessmentTemplate = await _context.PersonalAssessmentTemplate
                .FirstOrDefaultAsync(m => m.PersonalAssessmentTemplateID == id);
            if (personalAssessmentTemplate == null)
            {
                return NotFound();
            }

            return View(personalAssessmentTemplate);
        }

        // GET: PersonalAssessmentTemplates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonalAssessmentTemplates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonalAssessmentTemplateID,PersonalAssessmentTemplateName,AreaOfCoaching,LinkToPDF,BriefDescription,DetailedDescription,LinkToImage")] PersonalAssessmentTemplate personalAssessmentTemplate)
        {
            if (ModelState.IsValid)
            {
                personalAssessmentTemplate.PersonalAssessmentTemplateID = Guid.NewGuid();
                _context.Add(personalAssessmentTemplate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personalAssessmentTemplate);
        }

        // GET: PersonalAssessmentTemplates/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalAssessmentTemplate = await _context.PersonalAssessmentTemplate.FindAsync(id);
            if (personalAssessmentTemplate == null)
            {
                return NotFound();
            }
            return View(personalAssessmentTemplate);
        }

        // POST: PersonalAssessmentTemplates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("PersonalAssessmentTemplateID,PersonalAssessmentTemplateName,AreaOfCoaching,LinkToPDF,BriefDescription,DetailedDescription,LinkToImage")] PersonalAssessmentTemplate personalAssessmentTemplate)
        {
            if (id != personalAssessmentTemplate.PersonalAssessmentTemplateID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personalAssessmentTemplate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonalAssessmentTemplateExists(personalAssessmentTemplate.PersonalAssessmentTemplateID))
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
            return View(personalAssessmentTemplate);
        }

        // GET: PersonalAssessmentTemplates/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalAssessmentTemplate = await _context.PersonalAssessmentTemplate
                .FirstOrDefaultAsync(m => m.PersonalAssessmentTemplateID == id);
            if (personalAssessmentTemplate == null)
            {
                return NotFound();
            }

            return View(personalAssessmentTemplate);
        }

        // POST: PersonalAssessmentTemplates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var personalAssessmentTemplate = await _context.PersonalAssessmentTemplate.FindAsync(id);
            _context.PersonalAssessmentTemplate.Remove(personalAssessmentTemplate);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonalAssessmentTemplateExists(Guid id)
        {
            return _context.PersonalAssessmentTemplate.Any(e => e.PersonalAssessmentTemplateID == id);
        }
    }
}
