using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Accelerated_Digital_Delivery_Coaching_Program.Models;
using Microsoft.EntityFrameworkCore.Query;

namespace Accelerated_Digital_Delivery_Coaching_Program.Controllers
{
    public class ProductBacklogsController : Controller
    {
        private readonly AddDBContext _context;

        public ProductBacklogsController(AddDBContext context)
        {
            _context = context;
        }

        // GET: ProductBacklogs
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProductBacklog.ToListAsync());
        }

        // GET: ProductBacklogs/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productBacklog = await _context.ProductBacklog.Include(d => d.ProductBacklogItems).FirstOrDefaultAsync(m => m.ProductBacklogID == id);
            


            if (productBacklog == null)
            {
                return NotFound();
            }

            return View(productBacklog);
        }

        // GET: ProductBacklogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductBacklogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductBacklogID,ProductBacklogName,ProductDefintionOfDone")] ProductBacklog productBacklog)
        {
            if (ModelState.IsValid)
            {
                productBacklog.ProductBacklogID = Guid.NewGuid();
                _context.Add(productBacklog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productBacklog);
        }

        // GET: ProductBacklogs/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productBacklog = await _context.ProductBacklog.FindAsync(id);
            if (productBacklog == null)
            {
                return NotFound();
            }
            return View(productBacklog);
        }

        // POST: ProductBacklogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ProductBacklogID,ProductBacklogName,ProductDefintionOfDone")] ProductBacklog productBacklog)
        {
            if (id != productBacklog.ProductBacklogID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productBacklog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductBacklogExists(productBacklog.ProductBacklogID))
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
            return View(productBacklog);
        }

        // GET: ProductBacklogs/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productBacklog = await _context.ProductBacklog
                .FirstOrDefaultAsync(m => m.ProductBacklogID == id);
            if (productBacklog == null)
            {
                return NotFound();
            }

            return View(productBacklog);
        }

        // POST: ProductBacklogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var productBacklog = await _context.ProductBacklog.FindAsync(id);
            _context.ProductBacklog.Remove(productBacklog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductBacklogExists(Guid id)
        {
            return _context.ProductBacklog.Any(e => e.ProductBacklogID == id);
        }
    }
}
