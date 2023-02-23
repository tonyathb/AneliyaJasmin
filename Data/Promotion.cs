using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jasmin.Data
{
    public class Promotion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }
        public int StartingDate { get; set; }
        public int EndingDate { get; set;}

        //M:1
        public int ParfumesId { get; set; }
        public Parfume Parfumes { get; set; }
        
        
        //1:M
        public ICollection<OrderPromotion> OrderPromotions { get; set; }

    }
}
