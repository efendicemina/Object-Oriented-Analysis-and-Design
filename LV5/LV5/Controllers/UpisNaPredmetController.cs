using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LV5.Data;
using LV5.Models;

namespace LV5.Controllers
{
    public class UpisNaPredmetController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UpisNaPredmetController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UpisNaPredmet
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.UpisNaPredmet.Include(u => u.Predmet).Include(u => u.Student);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: UpisNaPredmet/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var upisNaPredmet = await _context.UpisNaPredmet
                .Include(u => u.Predmet)
                .Include(u => u.Student)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (upisNaPredmet == null)
            {
                return NotFound();
            }

            return View(upisNaPredmet);
        }

        // GET: UpisNaPredmet/Create
        public IActionResult Create()
        {
            ViewData["PredmetId"] = new SelectList(_context.Predmet, "ID", "Naziv");
            ViewData["StudentId"] = new SelectList(_context.Student, "BrojIndeksa", "BrojIndeksa");
            return View();
        }

        // POST: UpisNaPredmet/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,StudentId,PredmetId,DatumUpisa")] UpisNaPredmet upisNaPredmet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(upisNaPredmet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PredmetId"] = new SelectList(_context.Predmet, "ID", "Naziv", upisNaPredmet.PredmetId);
            ViewData["StudentId"] = new SelectList(_context.Student, "BrojIndeksa", "BrojIndeksa", upisNaPredmet.StudentId);
            return View(upisNaPredmet);
        }

        // GET: UpisNaPredmet/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var upisNaPredmet = await _context.UpisNaPredmet.FindAsync(id);
            if (upisNaPredmet == null)
            {
                return NotFound();
            }
            ViewData["PredmetId"] = new SelectList(_context.Predmet, "ID", "Naziv", upisNaPredmet.PredmetId);
            ViewData["StudentId"] = new SelectList(_context.Student, "BrojIndeksa", "BrojIndeksa", upisNaPredmet.StudentId);
            return View(upisNaPredmet);
        }

        // POST: UpisNaPredmet/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,StudentId,PredmetId,DatumUpisa")] UpisNaPredmet upisNaPredmet)
        {
            if (id != upisNaPredmet.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(upisNaPredmet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UpisNaPredmetExists(upisNaPredmet.ID))
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
            ViewData["PredmetId"] = new SelectList(_context.Predmet, "ID", "Naziv", upisNaPredmet.PredmetId);
            ViewData["StudentId"] = new SelectList(_context.Student, "BrojIndeksa", "BrojIndeksa", upisNaPredmet.StudentId);
            return View(upisNaPredmet);
        }

        // GET: UpisNaPredmet/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var upisNaPredmet = await _context.UpisNaPredmet
                .Include(u => u.Predmet)
                .Include(u => u.Student)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (upisNaPredmet == null)
            {
                return NotFound();
            }

            return View(upisNaPredmet);
        }

        // POST: UpisNaPredmet/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var upisNaPredmet = await _context.UpisNaPredmet.FindAsync(id);
            _context.UpisNaPredmet.Remove(upisNaPredmet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UpisNaPredmetExists(int id)
        {
            return _context.UpisNaPredmet.Any(e => e.ID == id);
        }
    }
}
