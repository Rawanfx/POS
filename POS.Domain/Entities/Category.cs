using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Domain.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ?Description { get; set; }
     
    }
}
