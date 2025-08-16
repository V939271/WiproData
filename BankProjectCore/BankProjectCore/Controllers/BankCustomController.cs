using BankProjectCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace BankProjectCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankCustomController : ControllerBase
    {
        private readonly BankDbContext _context;

        public BankCustomController(BankDbContext context)
        {
            _context = context;
        }

        [HttpPost("/withdraw/{accountNo}/{transAmount}")]
        public async Task<ActionResult<string>> WithdrawAmount(int accountNo, decimal transAmount)
        {
            Account? account = _context.Accounts.Where(x => x.AccountNo == accountNo).FirstOrDefault();
            if (account == null)
            {
                return NotFound();
            }
            if (account.Amount - transAmount < 0)
            {
                return "Insufficient Funds...";
            }
            account.Amount = account.Amount - transAmount;
            Trans trans = new Trans();
            trans.TranAmount = transAmount;
            trans.TranType = "D";
            trans.AccountNo = accountNo;
            _context.Trans.Add(trans);
            _context.SaveChanges();
            return "Amount Debited From Your Account...";

        }

        [HttpPost("/deposit/{accountNo}/{tranAmount}")]
        public async Task<ActionResult<string>> DepositAmount(int accountNo, decimal tranAmount)
        {
            Account? account = _context.Accounts.Where(x => x.AccountNo == accountNo).FirstOrDefault();
            if (account == null)
            {
                return NotFound();
            }
            account.Amount = account.Amount + tranAmount;
            Trans trans = new Trans();
            trans.TranAmount = tranAmount;
            trans.TranType = "C";
            trans.AccountNo = accountNo;
            _context.Trans.Add(trans);
            _context.SaveChanges();
            return "Amount Credited to Your Account Successfully...";
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Account>> SearchAccount(int id)
        {
            Account account = await _context.Accounts.Where(x => x.AccountNo == id).FirstOrDefaultAsync();
            if (account == null)
            {
                return NotFound();
            }
            return account;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Account>>> ShowAccount()
        {
            return await _context.Accounts.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<string>> CreatAccount(Account account)
        {
            int accountNo = _context.Accounts.Max(x => x.AccountNo);
            accountNo++;
            account.AccountNo = accountNo;
            _context.Accounts.Add(account);
            await _context.SaveChangesAsync();
            return "Account Created Successfully...";
        }
    }
}