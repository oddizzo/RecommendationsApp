using RecommendationsApp.Dtos;
using RecommendationsApp.Interfaces;
using RecommendationsApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecommendationsApp.Modules
{
    internal class ProductModule
    {
        private List<Product> products;
        private IProductService productService;

        internal ProductModule()
        {
            productService = new ProductService();
            products = productService.GetAllProducts().Result;
        }

        internal List<Product> getProducts()
        {
            return products.ToList();
        }

        internal Product getProductById(int productId)
        {
            return products.Where(x => x.Id == productId).First();
        }
    }
}
