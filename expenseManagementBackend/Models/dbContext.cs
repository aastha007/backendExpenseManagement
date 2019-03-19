using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace expenseManagementBackend.Models
{
    public class dbContext:DbContext
    {
        public dbContext(DbContextOptions<dbContext> options):base(options)
        {

        }
        public DbSet<user> user { get; set; }
        public DbSet<Income> Income { get; set; }
        public DbSet<IncomeCategory> IncomeCategory { get; set; }
        public DbSet<Expense> Expense { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategory { get; set; }
    }
}
