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
    public class PersonNotesController : Controller
    {
        private readonly AddDBContext _context;

        public PersonNotesController(AddDBContext context)
        {
            _context = context;
        }

        // GET: PersonNotes
        public async Task<IActionResult> Index()
        {
            var addDBContext = _context.PersonNote.Include(p => p.Person);
            return View(await addDBContext.ToListAsync());
        }

        // GET: PersonNotes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNote = await _context.PersonNote
                .Include(p => p.Person)
                .FirstOrDefaultAsync(m => m.PersonNoteID == id);
            if (personNote == null)
            {
                return NotFound();
            }

            return View(personNote);
        }

        // GET: PersonNotes/Create
        public IActionResult Create()
        {
            ViewData["PersonID"] = new SelectList(_context.Persons, "PersonID", "PersonID");
            return View();
        }

        // POST: PersonNotes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonNoteID,NoteDate,PersonID,Notes")] PersonNote personNote)
        {
            if (ModelState.IsValid)
            {
                personNote.PersonNoteID = Guid.NewGuid();
                _context.Add(personNote);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PersonID"] = new SelectList(_context.Persons, "PersonID", "PersonID", personNote.PersonID);
            return View(personNote);
        }

        // POST: PersonNotes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateNoteWithPersonIDInPersonalCoaching([Bind("PersonNoteID,NoteDate,PersonID,Notes")] PersonNote personNote)
        {
            if (ModelState.IsValid)
            {
                personNote.PersonNoteID = Guid.NewGuid();
                _context.Add(personNote);
                await _context.SaveChangesAsync();
                return RedirectToAction("PersonalCoachingDetails", "People", new { id = personNote.PersonID });
            }
            ViewData["PersonID"] = new SelectList(_context.Persons, "PersonID", "PersonID", personNote.PersonID);
            return View(personNote);
        }

        // GET: PersonNotes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNote = await _context.PersonNote.FindAsync(id);
            if (personNote == null)
            {
                return NotFound();
            }
            ViewData["PersonID"] = new SelectList(_context.Persons, "PersonID", "PersonID", personNote.PersonID);
            return View(personNote);
        }

        // POST: PersonNotes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("PersonNoteID,NoteDate,PersonID,Notes")] PersonNote personNote)
        {
            if (id != personNote.PersonNoteID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personNote);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonNoteExists(personNote.PersonNoteID))
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
            ViewData["PersonID"] = new SelectList(_context.Persons, "PersonID", "PersonID", personNote.PersonID);
            return View(personNote);
        }

        // GET: PersonNotes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNote = await _context.PersonNote
                .Include(p => p.Person)
                .FirstOrDefaultAsync(m => m.PersonNoteID == id);
            if (personNote == null)
            {
                return NotFound();
            }

            return View(personNote);
        }

        // POST: PersonNotes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var personNote = await _context.PersonNote.FindAsync(id);
            _context.PersonNote.Remove(personNote);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonNoteExists(Guid id)
        {
            return _context.PersonNote.Any(e => e.PersonNoteID == id);
        }
    }
}
