using Microsoft.AspNetCore.Identity;

namespace react_1dentity.Models;

public class ApplicationUser : IdentityUser
{
    public List<Expense> Expenses { get; set; }
}
