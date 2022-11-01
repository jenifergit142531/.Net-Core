using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookMyShowApp.Data;
using BookMyShowApp.Models;

namespace BookMyShowApp.Controllers
{
  
    public class ElectronicProductsController : Controller
    {
        private readonly ApplicationDBContext _context;

        public ElectronicProductsController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: ElectronicProducts
        public async Task<IActionResult> Index()
        {
              return View(await _context.ElectronicProducts.ToListAsync());
        }

        // GET: ElectronicProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ElectronicProducts == null)
            {
                return NotFound();
            }

            var electronicProduct = await _context.ElectronicProducts
                .FirstOrDefaultAsync(m => m.Epid == id);
            if (electronicProduct == null)
            {
                return NotFound();
            }

            return View(electronicProduct);
        }

        // GET: ElectronicProducts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ElectronicProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Epid,DeviceName,Price,Quantity")] ElectronicProduct electronicProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(electronicProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(electronicProduct);
        }

        // GET: ElectronicProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ElectronicProducts == null)
            {
                return NotFound();
            }

            var electronicProduct = await _context.ElectronicProducts.FindAsync(id);
            if (electronicProduct == null)
            {
                return NotFound();
            }
            return View(electronicProduct);
        }

        // POST: ElectronicProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Epid,DeviceName,Price,Quantity")] ElectronicProduct electronicProduct)
        {
            if (id != electronicProduct.Epid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(electronicProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ElectronicProductExists(electronicProduct.Epid))
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
            return View(electronicProduct);
        }

        // GET: ElectronicProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ElectronicProducts == null)
            {
                return NotFound();
            }

            var electronicProduct = await _context.ElectronicProducts
                .FirstOrDefaultAsync(m => m.Epid == id);
            if (electronicProduct == null)
            {
                return NotFound();
            }

            return View(electronicProduct);
        }

        // POST: ElectronicProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ElectronicProducts == null)
            {
                return Problem("Entity set 'ApplicationDBContext.ElectronicProducts'  is null.");
            }
            var electronicProduct = await _context.ElectronicProducts.FindAsync(id);
            if (electronicProduct != null)
            {
                _context.ElectronicProducts.Remove(electronicProduct);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ElectronicProductExists(int id)
        {
          return _context.ElectronicProducts.Any(e => e.Epid == id);
        }
    }
}
