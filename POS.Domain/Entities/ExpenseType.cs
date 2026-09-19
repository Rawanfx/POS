namespace POS.Domain.Entities
{
    public class ExpenseType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Branch Branch { get; set; }
        public Guid BranchId { get; set; }
    }
}
