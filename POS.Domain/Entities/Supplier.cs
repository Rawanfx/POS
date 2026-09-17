namespace POS.Domain.Entities
{
    public class Supplier
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? ContactEmail { get; set; }
        public string PhoneNumber { get; set; }
    }
}
