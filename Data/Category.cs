namespace Jasmin.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Parfume> Parfumes { get; set; } 
    }
}
