using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RajorExamples.Models;

namespace RajorExamples.Pages.NewEmploys
{
    public class IndexModel : PageModel
    {
        private readonly RajorExamples.Models.EFCoreDbContext _context;

        public IndexModel(RajorExamples.Models.EFCoreDbContext context)
        {
            _context = context;
        }

        public IList<Employ> Employ { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Employ = await _context.Employees.ToListAsync();
        }
    }
}
