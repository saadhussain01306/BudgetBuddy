using Microsoft.AspNetCore.Mvc;
using ExpenseTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ExpenseContext _context;

        public ExpenseController(ExpenseContext context)
        {
            _context = context;
        }

        // GET: Expense/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Expense/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Amount,Category,Date,Description")] Expense expense)
        {
            if (ModelState.IsValid)
            {
                _context.Add(expense);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index)); // Redirect to Index after saving the expense
            }
            return View(expense);
        }

        // GET: Expense/Index
        public async Task<IActionResult> Index()
        {
            var expenses = await _context.Expenses.ToListAsync(); // Get all expenses from the database
            return View(expenses); // Pass the list of expenses to the view
        }
        public IActionResult Delete(int id)
        {
            var expense = _context.Expenses.Find(id);
            if (expense != null)
            {
                _context.Expenses.Remove(expense);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int id)
        {
            var expense = _context.Expenses.Find(id); // Retrieve the expense by Id
            if (expense == null)
            {
                return NotFound(); // If no expense is found, return 404
            }
            return View(expense); // Pass the expense to the view
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Expense expense)
        {
            if (ModelState.IsValid)
            {
                _context.Expenses.Update(expense); // Update the expense in the database
                _context.SaveChanges(); // Save the changes
                return RedirectToAction("Index"); // Redirect to the Index page
            }
            return View(expense); // Return the same view if validation fails
        }


    }
}
