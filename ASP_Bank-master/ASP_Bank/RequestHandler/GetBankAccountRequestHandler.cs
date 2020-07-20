using ASP_Bank.Infrastrcuture.Repositories;
using ASP_Bank.Models;
using ASP_Bank.Request;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ASP_Bank.RequestHandler
{
    public class GetBankAccountRequestHandler : IRequestHandler<GetBankAccountRequest, BankAccount>
    {
        private readonly IBankAccountRepository _bankAccountRespository;
        public GetBankAccountRequestHandler(IBankAccountRepository bankAccountRespository)
        {
            _bankAccountRespository = bankAccountRespository;
        }
        public async Task<BankAccount> Handle(GetBankAccountRequest request, CancellationToken cancellationToken)
        {
            var result = _bankAccountRespository.GetById(request.AccountId);
            return result;
        }
    }
}
