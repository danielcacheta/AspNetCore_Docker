using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExpenseManager.Models;

namespace ExpenseManager.Data
{
    public class ExpensesDBContext : DbContext
    {
        public ExpensesDBContext (DbContextOptions<ExpensesDBContext> options)
            : base(options)
        {
        }

        public DbSet<ExpenseManager.Models.Expense> Expenses { get; set; }
    }
}