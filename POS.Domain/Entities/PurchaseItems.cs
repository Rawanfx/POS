using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Domain.Entities
{
    public class PurchaseItems
    {
        public Guid Id { get; set; }
        [ForeignKey(nameof(Purchase))]
        public Guid PurchaseId { get; set; }
        public Purchase Purchase { get; set; } = new Purchase();
        [ForeignKey(nameof(Product))]
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = new Product();   
        public decimal UnitCost { get; set; }
        public int Quantity { get; set; }
    }
}
