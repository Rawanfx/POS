using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Entities
{
    public class ApplicationUser:IdentityUser
    {
        [ForeignKey(nameof(Branch))]
        public Guid BranchId { get; set; }
        public Branch Branch { get; set; }
    }
}
