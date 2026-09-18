using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Domain.Entities
{
    public class SaleItems
    {
        [ForeignKey(nameof (Product))]
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = new Product();
        [ForeignKey(nameof(Sale))]
        public Guid SalesId { get; set; }
        public Sale Sale { get; set; } = new Sale();
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
