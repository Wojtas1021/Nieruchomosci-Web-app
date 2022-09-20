using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nieruchomosci.Data.Data;
using Nieruchomosci.Data.Data.CMS;

namespace Nieruchomosci.Intranet.Controllers
{
    public class RekomendacjaController : Controller
    {
        private readonly NieruchomosciContext _context;

        public RekomendacjaController(NieruchomosciContext context)
        {
            _context = context;
        }

        // GET: Rekomendacja
        public async Task<IActionResult> Index()
        {
              return _context.Rekomendacja != null ? 
                          View(await _context.Rekomendacja.ToListAsync()) :
                          Problem("Entity set 'NieruchomosciIntranetContext.Rekomendacja'  is null.");
        }

        // GET: Rekomendacja/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Rekomendacja == null)
            {
                return NotFound();
            }

            var rekomendacja = await _context.Rekomendacja
                .FirstOrDefaultAsync(m => m.IdRekomendacji == id);
            if (rekomendacja == null)
            {
                return NotFound();
            }

            return View(rekomendacja);
        }

        // GET: Rekomendacja/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rekomendacja/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdRekomendacji,LinkRekomendacji,Foto,Ikona,Tresc,Pozycja,Komentarz,Przycisk,DataUtworzenia,DataPublikacji,Autor,Ocena,DataEdycji,CzyPubliczny,CzyAktywny")] Rekomendacja rekomendacja)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rekomendacja);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rekomendacja);
        }

        // GET: Rekomendacja/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Rekomendacja == null)
            {
                return NotFound();
            }

            var rekomendacja = await _context.Rekomendacja.FindAsync(id);
            if (rekomendacja == null)
            {
                return NotFound();
            }
            return View(rekomendacja);
        }

        // POST: Rekomendacja/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdRekomendacji,LinkRekomendacji,Foto,Ikona,Tresc,Pozycja,Komentarz,Przycisk,DataUtworzenia,DataPublikacji,Autor,Ocena,DataEdycji,CzyPubliczny,CzyAktywny")] Rekomendacja rekomendacja)
        {
            if (id != rekomendacja.IdRekomendacji)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rekomendacja);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RekomendacjaExists(rekomendacja.IdRekomendacji))
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
            return View(rekomendacja);
        }

        // GET: Rekomendacja/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Rekomendacja == null)
            {
                return NotFound();
            }

            var rekomendacja = await _context.Rekomendacja
                .FirstOrDefaultAsync(m => m.IdRekomendacji == id);
            if (rekomendacja == null)
            {
                return NotFound();
            }

            return View(rekomendacja);
        }

        // POST: Rekomendacja/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Rekomendacja == null)
            {
                return Problem("Entity set 'NieruchomosciIntranetContext.Rekomendacja'  is null.");
            }
            var rekomendacja = await _context.Rekomendacja.FindAsync(id);
            if (rekomendacja != null)
            {
                _context.Rekomendacja.Remove(rekomendacja);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RekomendacjaExists(int id)
        {
          return (_context.Rekomendacja?.Any(e => e.IdRekomendacji == id)).GetValueOrDefault();
        }
    }
}
