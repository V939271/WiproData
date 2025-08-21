using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcAdoEmployCrud.Models;

namespace MvcAdoEmployCrud.Controllers
{
    public class EmploysController : Controller
    {
        private readonly EFCoreDbContext _context;

        public EmploysController(EFCoreDbContext context)
        {
            _context = context;
        }

        // GET: Employs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employees.ToListAsync());
        }

        // GET: Employs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employ = await _context.Employees
                .FirstOrDefaultAsync(m => m.Empno == id);
            if (employ == null)
            {
                return NotFound();
            }

            return View(employ);
        }

        // GET: Employs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Gender,Dept,Desig,Basic")] Employ employ)
        {
            if (ModelState.IsValid)
            {
                // ✅ Generate Empno (Max + 1)
                var maxEmpno = _context.Employees.Any()
                               ? _context.Employees.Max(e => e.Empno)
                               : 0;

                employ.Empno = maxEmpno + 1;

                _context.Add(employ);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employ);
        }

        // GET: Employs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employ = await _context.Employees.FindAsync(id);
            if (employ == null)
            {
                return NotFound();
            }
            return View(employ);
        }

        // POST: Employs/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Empno,Name,Gender,Dept,Desig,Basic")] Employ employ)
        {
            if (id != employ.Empno)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // ✅ Ensure Empno is not changed manually
                    var existing = await _context.Employees.AsNoTracking()
                                                           .FirstOrDefaultAsync(e => e.Empno == id);
                    if (existing == null)
                    {
                        return NotFound();
                    }

                    employ.Empno = existing.Empno; // keep same Empno
                    _context.Update(employ);

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployExists(employ.Empno))
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
            return View(employ);
        }

        // GET: Employs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employ = await _context.Employees
                .FirstOrDefaultAsync(m => m.Empno == id);
            if (employ == null)
            {
                return NotFound();
            }

            return View(employ);
        }

        // POST: Employs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employ = await _context.Employees.FindAsync(id);
            if (employ != null)
            {
                _context.Employees.Remove(employ);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployExists(int id)
        {
            return _context.Employees.Any(e => e.Empno == id);
        }
    }
}
