namespace Jasmin.Data
{
    public class Type
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Aroma { get; set; }
        public ICollection<Parfume> Parfumes { get; set; }

    }
}
