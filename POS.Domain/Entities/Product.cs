using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Domain.Entities
{
    public class Product
    {
        public Guid  Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [ForeignKey(nameof (Category))]
        public Guid CategoryId { get; set; } 
        public Category Category { get; set; }
    }
}
