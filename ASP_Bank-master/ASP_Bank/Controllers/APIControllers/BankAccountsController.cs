using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASP_Bank.Data;
using ASP_Bank.Models;
using MediatR;
using ASP_Bank.Request;

namespace ASP_Bank.Controllers.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BankAccountsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/BankAccounts
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<BankAccount>>> GetBankAccounts()
        //{
        //    var request = new GetBankAccountRequest();
        //    var response = await _mediator.Send(request);
        //    return Ok(response);
        //}

        // GET: api/BankAccounts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BankAccount>> GetBankAccount(int id)
        {
            var request = new GetBankAccountRequest(id);
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        // PUT: api/BankAccounts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutBankAccount(int id, BankAccount bankAccount)
        //{
        //    //if (id != bankAccount.Id)
        //    //{
        //    //    return BadRequest();
        //    //}

        //    //_context.Entry(bankAccount).State = EntityState.Modified;

        //    //try
        //    //{
        //    //    await _context.SaveChangesAsync();
        //    //}
        //    //catch (DbUpdateConcurrencyException)
        //    //{
        //    //    if (!BankAccountExists(id))
        //    //    {
        //    //        return NotFound();
        //    //    }
        //    //    else
        //    //    {
        //    //        throw;
        //    //    }
        //    //}

        //    //return NoContent();

        //    //var request = new GetBankAccountRequest(id);

        //    //var response = await _mediator.Send(request);
        //    //return Ok(response);
        //}

        // POST: api/BankAccounts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPost]
        //public async Task<ActionResult<BankAccount>> PostBankAccount(BankAccount bankAccount)
        //{
        //    var request = new GetBankAccountRequest(bankAccount.Id);

        //    var response = await _mediator.Send(request);
        //    return Ok(response);

        //}

        //// DELETE: api/BankAccounts/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<BankAccount>> DeleteBankAccount(int id)
        //{
        //    var bankAccount = new GetBankAccountRequest(id);
        //    if (bankAccount == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.BankAccounts.Remove(bankAccount);
        //    await _context.SaveChangesAsync();

        //    return bankAccount;
        //}

        //private bool BankAccountExists(int id)
        //{
        //    return _context.BankAccounts.Any(e => e.Id == id);
        //}
    }
}
