namespace App21072018.Core.Domains
{
    public class Product:Entity<int>
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public Category Category { get; set; }
    }
}
