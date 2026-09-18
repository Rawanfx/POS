
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Domain.Entities
{
    public class Purchase
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        [ForeignKey(nameof(Supplier))]
        public Guid SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        [ForeignKey(nameof(Branch))]
        public Guid BranchId { get; set; }
        public Branch Branch { get; set; }
        [ForeignKey(nameof(ApplicationUser))]
        public Guid UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalPaid { get; set; }
        public decimal Discount { get; set; }
    }

}
