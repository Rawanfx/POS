namespace POS.Domain.Entities
{
    public class Inventory
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public Guid BranchId { get; set; }
        public Branch Branch { get; set; }
        public int Quantity { get; set; }
    }
}
