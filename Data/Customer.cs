using Microsoft.AspNetCore.Identity;

namespace Jasmin.Data
{
    public class Customer : IdentityUser
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public ICollection<OrderParfume> OrderParfumes { get; set; }
        public ICollection<OrderPromotion> OrderPromotions { get; set; }
    }
}
