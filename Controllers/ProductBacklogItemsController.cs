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
    public class ProductBacklogItemsController : Controller
    {
        private readonly AddDBContext _context;

        public ProductBacklogItemsController(AddDBContext context)
        {
            _context = context;
        }

        // GET: ProductBacklogItems
        public async Task<IActionResult> Index()
        {
            var addDBContext = _context.ProductBacklogItem.Include(p => p.ProductBacklog);
            return View(await addDBContext.ToListAsync());
        }

        // GET: ProductBacklogItems/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productBacklogItem = await _context.ProductBacklogItem
                .Include(p => p.ProductBacklog)
                .FirstOrDefaultAsync(m => m.ProductBacklogItemId == id);
            if (productBacklogItem == null)
            {
                return NotFound();
            }

            return View(productBacklogItem);
        }

        // GET: ProductBacklogItems/Create
        public IActionResult Create()
        {
            ViewData["ProductBacklogId"] = new SelectList(_context.ProductBacklog, "ProductBacklogID", "ProductBacklogID");
            return View();
        }

        // POST: ProductBacklogItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductBacklogItemId,ProductBacklogItemName,AcceptanceCriteria,ComparativePoints,ProductBacklogId")] ProductBacklogItem productBacklogItem)
        {
            if (ModelState.IsValid)
            {
                productBacklogItem.ProductBacklogItemId = Guid.NewGuid();
                _context.Add(productBacklogItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductBacklogId"] = new SelectList(_context.ProductBacklog, "ProductBacklogID", "ProductBacklogID", productBacklogItem.ProductBacklogId);
            return View(productBacklogItem);
        }

        // GET: ProductBacklogItems/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productBacklogItem = await _context.ProductBacklogItem.FindAsync(id);
            if (productBacklogItem == null)
            {
                return NotFound();
            }
            ViewData["ProductBacklogId"] = new SelectList(_context.ProductBacklog, "ProductBacklogID", "ProductBacklogID", productBacklogItem.ProductBacklogId);
            return View(productBacklogItem);
        }

        // POST: ProductBacklogItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ProductBacklogItemId,ProductBacklogItemName,AcceptanceCriteria,ComparativePoints,ProductBacklogId")] ProductBacklogItem productBacklogItem)
        {
            if (id != productBacklogItem.ProductBacklogItemId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productBacklogItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductBacklogItemExists(productBacklogItem.ProductBacklogItemId))
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
            ViewData["ProductBacklogId"] = new SelectList(_context.ProductBacklog, "ProductBacklogID", "ProductBacklogID", productBacklogItem.ProductBacklogId);
            return View(productBacklogItem);
        }

        // GET: ProductBacklogItems/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productBacklogItem = await _context.ProductBacklogItem
                .Include(p => p.ProductBacklog)
                .FirstOrDefaultAsync(m => m.ProductBacklogItemId == id);
            if (productBacklogItem == null)
            {
                return NotFound();
            }

            return View(productBacklogItem);
        }

        // POST: ProductBacklogItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var productBacklogItem = await _context.ProductBacklogItem.FindAsync(id);
            _context.ProductBacklogItem.Remove(productBacklogItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductBacklogItemExists(Guid id)
        {
            return _context.ProductBacklogItem.Any(e => e.ProductBacklogItemId == id);
        }
    }
}
