using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Jasmin.Data
{
    public class Parfume
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Quantity { get; set; }
        //M:1
        public int CategoryId { get; set; }
        public Category Categories { get; set; }
        //M:1
        public int TypeId { get; set; }
        public Type Types { get; set; }

        public string Image { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime DateReg { get; set; }
        
             //1:M  
        public ICollection<Promotion> Promotions { get; set; } 
        public ICollection<OrderParfume> OrderParfumes { get; set; } 

    }
}
