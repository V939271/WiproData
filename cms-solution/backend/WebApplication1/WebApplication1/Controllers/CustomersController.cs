// File: Controllers/CustomersController.cs
// Fully updated version with safer null-checks, case-insensitive “contains” search
// and case-insensitive authentication. Ready to drop into your project.

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Middleware;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly CmsDbContext _ctx;
        public CustomersController(CmsDbContext ctx) => _ctx = ctx;

        // ─────────────────────────────────────────────
        // 1. List all customers
        // ─────────────────────────────────────────────
        [HttpGet]
        public async Task<IEnumerable<Customer>> GetAll() =>
            await _ctx.Customers.ToListAsync();

        // ─────────────────────────────────────────────
        // 2. Search by Id
        // ─────────────────────────────────────────────
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Customer>> Get(int id) =>
            await _ctx.Customers.FindAsync(id) is { } c ? c : NotFound();

        // ─────────────────────────────────────────────
        // 3. Search by UserName  (partial, case-insensitive)
        //    Example: /api/Customers/byusername/ven
        // ─────────────────────────────────────────────
        [HttpGet("byusername/{uname}")]
        public async Task<ActionResult<Customer>> GetByUser(string uname)
        {
            // Use SQL LIKE for efficient, case-insensitive search on most collations.
            var cust = await _ctx.Customers
                .FirstOrDefaultAsync(c => c.CustUserName != null &&
                                          EF.Functions.Like(c.CustUserName, $"%{uname}%"));

            return cust is null ? NotFound() : cust;
        }

        // ─────────────────────────────────────────────
        // 4. Add customer  – auto-Id + AES encryption
        // ─────────────────────────────────────────────
        [HttpPost]
        public async Task<string> Post(Customer c)
        {
            c.CustId = (_ctx.Customers.Max(x => (int?)x.CustId) ?? 0) + 1;
            c.CustPassword = EncryptionHelper.Encrypt(c.CustPassword!);
            _ctx.Customers.Add(c);
            await _ctx.SaveChangesAsync();
            return "Customer Added Successfully...";
        }

        // ─────────────────────────────────────────────
        // 5. Authenticate  (case-insensitive username)
        //    Returns 1 = success, 0 = failure
        // ─────────────────────────────────────────────
        [HttpGet("auth/{uname}/{pwd}")]
        public async Task<int> Auth(string uname, string pwd)
        {
            var rec = await _ctx.Customers
                .FirstOrDefaultAsync(c => c.CustUserName != null &&
                                          c.CustUserName.ToLower() == uname.ToLower());

            return rec != null && EncryptionHelper.Decrypt(rec.CustPassword!) == pwd ? 1 : 0;
        }
    }
}
