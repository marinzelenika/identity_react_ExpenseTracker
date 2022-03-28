namespace react_1dentity.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int amount { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public ApplicationUser user { get; set; }
    }
}
