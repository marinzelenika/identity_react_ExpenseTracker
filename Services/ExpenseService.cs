using Microsoft.EntityFrameworkCore;
using react_1dentity.Data;
using react_1dentity.Models;

namespace react_1dentity.Services
{
    public interface IExpenseService
    {
        Task<List<Expense>> GetAllExpensesByUser(int userId);
    }
    public class ExpenseService : IExpenseService
    {
        private readonly ApplicationDbContext _context;
        public ExpenseService(ApplicationDbContext Context)
        {
            _context = Context; 
        }
        public async Task<List<Expense>> GetAllExpensesByUser(int userId)
        {
            List<Expense> dbExpenses = await _context.Expenses.Where(e => e.user.Id == userId.ToString()).ToListAsync();
           
            return dbExpenses;
        }
    }
}
