using ASP_Bank.Data;
using ASP_Bank.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Bank.Request
{
    public class GetBankAccountRequest: IRequest<BankAccount>
    {
        private readonly ApplicationDbContext _context;
        public int AccountId { get; set; }
        public IList<BankAccount> BankAccounts { get; set; }
        public GetBankAccountRequest(int id)
        {
            AccountId = id;
        }

    }
}
