namespace Jasmin.Data
{
    public class OrderParfume
    {
        public int Id { get; set; }
        //M:1
        public string CustomerId { get; set; }
        public Customer Customers { get; set; } 
        //M:1
        public int ParfumeId { get; set; }
        public Parfume Parfumes { get; set; }

        public int QuantityOfGoods { get; set; }

        public int RegDate { get; set; }

    }
}
