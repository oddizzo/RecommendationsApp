using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecommendationsApp.Dtos;
using RecommendationsApp.Interfaces;

namespace RecommendationsApp.Services
{
    internal class ProductService : IProductService
    {
        private readonly List<Product> products;

        internal ProductService()
        {
           products = new List<Product>()
           {
                new Product()
                {
                    Id = 1212,
                    Name = "iPhone 14 Plus",
                    Description = "Apple iPhone 14 Plus Midnight 128GB 5G",
                    Category = "Cellphones"
                },
                new Product()
                {
                    Id = 2323,
                    Name = "Huawei Mate Xs",
                    Description = "Huawei Mate Xs 2 512GB 4G Dual Sim",
                    Category = "Cellphones"
                },
                new Product()
                {
                    Id = 3434,
                    Name = "Samsung Galaxy Flip 4",
                    Description = "Samsung Galaxy Flip 4 Graphite 256GB 5G",
                    Category = "Cellphones"
                },
                new Product()
                {
                    Id = 4545,
                    Name = "Asus i7 UX5400EG",
                    Description = "Asus i7 UX5400EG 16GB 512 GB SSD 12th Gen",
                    Category = "Laptops"
                },
                new Product()
                {
                    Id = 5656,
                    Name = "Dell Inspiron 3500",
                    Description = "Dell Inspiron 3500 G3 Gaming Laptop",
                    Category = "Laptops"
                },
                new Product()
                {
                    Id = 6767,
                    Name = "HP Chromebook x360",
                    Description = "HP Chromebook x360 14c, Core i3",
                    Category = "Laptops"
                },
                new Product()
                {
                    Id = 7878,
                    Name = "Topline Mechanic Toolset",
                    Description = "Topline Garage Mechanic Toolset 88Pce",
                    Category = "DIY"
                },
                new Product()
                {
                    Id = 8989,
                    Name = "Bosch CIRCULAR SAW",
                    Description = "Bosch 1400W CIRCULAR SAW GKS 190",
                    Category = "DIY"
                },
                new Product()
                {
                    Id = 9090,
                    Name = "Fragram Inverter Welder",
                    Description = "Fragram 160AMP Inverter Welder W4049",
                    Category = "DIY"
                }
           };
        }

        public Task<List<Product>> GetAllProducts()
        {
            return Task.FromResult(products);
        }
    }
}
