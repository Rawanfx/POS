using POS.Domain.Enums;

namespace POS.Domain.Entities
{
    public class LedgerEntry
    {
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Guid BranchId { get; set; }
        public Branch Branch { get; set; }
        public LedgerEntryStatus Status { get; set; }
        public Guid ?ExpenseTypeId { get; set; }
        public ExpenseType? ExpenseType { get; set; }

    }
}
