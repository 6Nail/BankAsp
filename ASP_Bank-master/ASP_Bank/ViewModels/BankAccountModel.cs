using ASP_Bank.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Bank.ViewModels
{
    public class BankAccountModel
    {
        private IdentityUser Person { get; set; }
        public string Number { get; set; }
        public IList<BankCard> BankCards { get; set; }
    }
}
