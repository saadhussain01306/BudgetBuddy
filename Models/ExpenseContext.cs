using Microsoft.EntityFrameworkCore; // Required for DbContext
using ExpenseTracker.Models; // Include the namespace for the Expense model

namespace ExpenseTracker.Models
{
    public class ExpenseContext : DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options)
            : base(options)
        {
        }

        public DbSet<Expense> Expenses { get; set; } // Ensure 'Expense' is recognized here
    }
}
