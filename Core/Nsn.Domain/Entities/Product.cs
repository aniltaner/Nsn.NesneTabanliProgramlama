using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nsn.Domain.Common;

namespace Nsn.Domain.Entities
{
    public class Product : EntityBase
    {
        public Product()
        {
            
        }
        
        public Product(string name, decimal price, string ımageUrl, string description)
        {
            Name = name;
            Price = price;
            ImageUrl = ımageUrl;
            Description = description;
        }
        public required string Name { get; set; }

        public required decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public required string Description { get; set; }

        public ICollection<Category> Categories { get; set; }
    }
}
