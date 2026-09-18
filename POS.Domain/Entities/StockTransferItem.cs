namespace POS.Domain.Entities
{
    public class StockTransferItem
    {
        public Guid StockTransferId { get; set; }
        public StockTransfer StockTransfer { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
