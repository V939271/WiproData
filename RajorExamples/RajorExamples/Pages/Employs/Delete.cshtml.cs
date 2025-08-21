using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RajorExamples.Models;

namespace RajorExamples.Pages.Employs
{
    public class DeleteModel : PageModel
    {
        private readonly EFCoreDbContext _context;

        public DeleteModel(EFCoreDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Employ Employ { get; set; } = default!;

        // GET: /Employs/Delete/1
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employ = await _context.Employees
                                   .FirstOrDefaultAsync(x => x.Empno == id);

            if (Employ == null)
            {
                return NotFound();
            }

            return Page();
        }

        // POST: /Employs/Delete/1
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employ = await _context.Employees.FindAsync(id);

            if (employ != null)
            {
                _context.Employees.Remove(employ);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
