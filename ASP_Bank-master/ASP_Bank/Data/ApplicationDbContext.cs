using System;
using System.Collections.Generic;
using System.Text;
using ASP_Bank.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASP_Bank.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public virtual DbSet<BankAccount> BankAccounts { get; set; }
        public virtual DbSet<BankCard> BankCards { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServiceProvider> ServiceProviders { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
