using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace ASP_Bank.Models
{
    public class BankAccount
    {
        public int Id { get; set; }

        // KZ23423423424324
        [Required]
        public string Number { get; set; }


        public string PersonId { get; set; }
        private IdentityUser Person { get; set; }

        // годен до
        public DateTime ValidTill { get; set; }

        public IList<BankCard> BankCards { get; set; }

    }
}