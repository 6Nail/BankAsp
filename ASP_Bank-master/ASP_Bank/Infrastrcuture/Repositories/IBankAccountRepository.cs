using ASP_Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Bank.Infrastrcuture.Repositories
{
    public interface IBankAccountRepository
    {
        BankAccount GetById(int id);

        IList<BankAccount> GetAll();

        BankAccount Create(BankAccount studentDto);

        BankAccount Update(int id, BankAccount studentDto);
        BankAccount Remove(int id);
    }
}
