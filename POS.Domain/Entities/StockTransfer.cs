using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Domain.Entities
{
    public class StockTransfer
    {
        public Guid Id { get; set; }
        [ForeignKey(nameof(fromBranch))]
        public Guid FromBranch { get; set; }
        [ForeignKey(nameof(toBranch))]
        public Guid ToBranch { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey(nameof(ApplicationUser))]
        public Guid CreatedByUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public Branch fromBranch { get; set; }
        public Branch toBranch { get; set; }
    }
}
