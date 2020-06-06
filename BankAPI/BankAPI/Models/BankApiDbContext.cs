using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAPI.Models
{
    public class BankApiDbContext : DbContext
    {
        public BankApiDbContext(DbContextOptions<BankApiDbContext> options) : base(options)
        {}

        public DbSet<Bank> Banks { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
    }
}
