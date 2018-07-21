using System.Collections.Generic;

namespace App21072018.Core.Domains
{
    public class Category:Entity<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
