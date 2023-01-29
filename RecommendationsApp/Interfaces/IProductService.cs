using RecommendationsApp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecommendationsApp.Interfaces
{
    internal interface IProductService
    {
        public Task<List<Product>> GetAllProducts();
    }
}
