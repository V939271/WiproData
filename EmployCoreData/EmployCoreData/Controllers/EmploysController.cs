using EmployCoreData.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace EmployCoreData.Controllers
{
    //    [Route("api/[controller]")]
    //    [ApiController]
    //    public class EmploysController : ControllerBase
    //    {
    //        private readonly EFCoreDbContext _context;

    //        public EmploysController(EFCoreDbContext context)
    //        {
    //            _context = context;
    //        }

    //        // GET: api/Employs
    //        [HttpGet]
    //        public async Task<ActionResult<IEnumerable<Employ>>> GetEmployees()
    //        {
    //            return await _context.Employees.ToListAsync();
    //        }

    //        // GET: api/Employs/5
    //        [HttpGet("{id}")]
    //        public async Task<ActionResult<Employ>> GetEmploy(int id)
    //        {
    //            var employ = await _context.Employees.FindAsync(id);

    //            if (employ == null)
    //            {
    //                return NotFound();
    //            }

    //            return employ;
    //        }

    //        // PUT: api/Employs/5
    //        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    //        [HttpPut("{id}")]
    //        public async Task<IActionResult> PutEmploy(int id, Employ employ)
    //        {
    //            if (id != employ.Empno)
    //            {
    //                return BadRequest();
    //            }

    //            _context.Entry(employ).State = EntityState.Modified;

    //            try
    //            {
    //                await _context.SaveChangesAsync();
    //            }
    //            catch (DbUpdateConcurrencyException)
    //            {
    //                if (!EmployExists(id))
    //                {
    //                    return NotFound();
    //                }
    //                else
    //                {
    //                    throw;
    //                }
    //            }

    //            return NoContent();
    //        }

    //        // POST: api/Employs
    //        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    //        [HttpPost]
    //        public async Task<ActionResult<Employ>> PostEmploy(Employ employ)
    //        {
    //            _context.Employees.Add(employ);
    //            await _context.SaveChangesAsync();

    //            return CreatedAtAction("GetEmploy", new { id = employ.Empno }, employ);
    //        }

    //        // DELETE: api/Employs/5
    //        [HttpDelete("{id}")]
    //        public async Task<IActionResult> DeleteEmploy(int id)
    //        {
    //            var employ = await _context.Employees.FindAsync(id);
    //            if (employ == null)
    //            {
    //                return NotFound();
    //            }

    //            _context.Employees.Remove(employ);
    //            await _context.SaveChangesAsync();

    //            return NoContent();
    //        }

    //        private bool EmployExists(int id)
    //        {
    //            return _context.Employees.Any(e => e.Empno == id);
    //        }
    //    }

    [Route("api/[controller]")]
    [ApiController]
    public class EmploysController : ControllerBase
    {
        private readonly EFCoreDbContext _context;

        public EmploysController(EFCoreDbContext context)
        {
            _context = context;
        }

        // GET: api/Employs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employ>>> GetEmployees()
        {
            Console.WriteLine("Sending Mail");
            Console.WriteLine(SendMail.MailInfo("kumarqwe944@gmail.com", "Dotnet Code", "This is My First Mail in Dotnet"));
            return await _context.Employees.ToListAsync();
        }

        // GET: api/Employs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employ>> GetEmploy(int id)
        {
            try
            {
                string smtpUser = "prasanna.vsp80@gmail.com"; // Gmail login account
                string appPassword = "hfol wjgf apqn bvhw";      // App password from Google
                string fromAddress = "prasanna.vsp80@gmail.com"; // Must be allowed as alias
                string toAddress = "aavesha5@gmail.com";

                using (MailMessage message = new MailMessage())
                {
                    message.From = new MailAddress(fromAddress);
                    message.To.Add(toAddress);
                    message.Subject = "This is the Subject Line!";
                    message.Body = "This is actual message";
                    message.IsBodyHtml = false;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential(smtpUser, appPassword);
                        smtp.EnableSsl = true; // For SSL over port 465
                        smtp.Send(message);
                    }
                }

                Console.WriteLine("Sent message successfully....");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }

            //Console.WriteLine("Sending Mail");
            //Console.WriteLine(SendMail.MailInfo("prassucp@gmail.com", "Dotnet Code", "This is My First Mail in Dotnet"));
            //return await _context.Employees.ToListAsync();
            var employ = await _context.Employees.FindAsync(id);

            if (employ == null)
            {
                return NotFound();
            }

            return employ;
        }

        // PUT: api/Employs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmploy(int id, Employ employ)
        {
            if (id != employ.Empno)
            {
                return BadRequest();
            }

            _context.Entry(employ).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Employs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Employ>> PostEmploy(Employ employ)
        {
            _context.Employees.Add(employ);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmploy", new { id = employ.Empno }, employ);
        }

        // DELETE: api/Employs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmploy(int id)
        {
            var employ = await _context.Employees.FindAsync(id);
            if (employ == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(employ);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmployExists(int id)
        {
            return _context.Employees.Any(e => e.Empno == id);
        }
    }
}
