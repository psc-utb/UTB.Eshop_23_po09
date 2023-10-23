using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTB.Eshop.Domain.Entities;

namespace UTB.Eshop.Infrastructure.Database
{
    internal class DatabaseInit
    {
        public IList<Product> GetProducts()
        {
            IList<Product> products = new List<Product>();


            products.Add(
                new Product()
                {
                    Id = 1,
                    Name = "Rohlík",
                    Description = "nejlepší rohlík na světě",
                    Price = 10,
                    ImageSrc = "/img/products/produkty-01.jpg"
                });

            products.Add(
                new Product()
                {
                    Id = 2,
                    Name = "Chleba",
                    Description = "nejlepší chleba ve vesmíru",
                    Price = 50,
                    ImageSrc = "/img/products/produkty-02.jpg"
                });


            products.Add(
                new Product()
                {
                    Id = 3,
                    Name = "Bageta",
                    Description = "nejlepší bageta v galaxii",
                    Price = 35,
                    ImageSrc = "/img/products/produkty-05.jpg"
                });

            products.Add(
                new Product()
                {
                    Id = 4,
                    Name = "Dalamánek",
                    Description = "nejlepší dalamánek ve sluneční soustavě",
                    Price = 8,
                    ImageSrc = "/img/products/produkty-06.jpg"
                });

            products.Add(
                new Product()
                {
                    Id = 5,
                    Name = "Vánočka",
                    Description = "není moc dobrá, ale máme ji tu",
                    Price = 80,
                    ImageSrc = "/img/products/produkty-03.jpg"
                });


            return products;
        }


        public IList<Carousel> GetCarousels()
        {
            IList<Carousel> carousels = new List<Carousel>();


            carousels.Add(new Carousel()
            {
                Id = 1,
                ImageSrc = "/img/carousel/how-to-become-an-information-technology-specialist160684886950141.jpg",
                ImageAlt = "First slide"
            });


            carousels.Add(new Carousel()
            {
                Id = 2,
                ImageSrc = "/img/carousel/Information-Technology-1-1.jpg",
                ImageAlt = "Second slide"
            });


            carousels.Add(new Carousel()
            {
                Id = 3,
                ImageSrc = "/img/carousel/itec-index-banner.jpg",
                ImageAlt = "Third slide"
            });


            return carousels;
        }
    }
}
