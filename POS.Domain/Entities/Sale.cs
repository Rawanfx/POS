using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Domain.Entities
{
    public class Sale
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        [ForeignKey(nameof(ApplicationUser))]
        public string UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public Guid BranchId { get; set; }
        public Branch Branch { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalPaid { get; set; } = 0;
        public decimal Discount { get; set; } = 0;
    }
}
