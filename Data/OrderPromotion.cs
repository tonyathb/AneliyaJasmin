namespace Jasmin.Data
{
    public class OrderPromotion
    {
        public int Id { get; set; }
        //M:1
        public string CustomerId { get; set; }
        public Customer Customers { get; set; }

        //M:1
        public int PromotionId { get; set; }  
        public Promotion Promotions { get; set; }
                
        public int QuantityOfGoods { get; set; }

        public DateTime RegDate { get; set; }
       
 
    }
}
