namespace ExpenseTracker.Models // Ensure the namespace is correct
{
    public class Expense
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty; // Non-nullable property
        public string Category { get; set; } = string.Empty;    // Non-nullable property
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
