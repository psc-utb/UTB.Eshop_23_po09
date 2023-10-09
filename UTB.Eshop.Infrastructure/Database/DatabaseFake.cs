using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTB.Eshop.Domain.Entities;

namespace UTB.Eshop.Infrastructure.Database
{
    public class DatabaseFake
    {
        public static List<Product> Products { get; set; }

        static DatabaseFake()
        {
            Products = new List<Product>();
            Products.Add(new Product()
            {
                Id = 1,
                Name = "iPhone",
                Description = "mobilni telefon",
                Price = 20,
                ImageSrc = ""
            });
        }
    }
}
