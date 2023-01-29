using RecommendationsApp.Dtos;
using RecommendationsApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecommendationsApp.Services
{
    internal class UserProductService : IUserProductService
    {
        private readonly List<UserProduct> userProducts;

        internal UserProductService()
        {
            userProducts = new List<UserProduct>()
            {
                new UserProduct()
                {
                    Id = 1,
                    UserId = 333,
                    ProductId = 9090
                },
                new UserProduct()
                {
                    Id = 2,
                    UserId = 111,
                    ProductId = 5656
                },
                new UserProduct()
                {
                    Id = 3,
                    UserId = 222,
                    ProductId = 2323
                },
                new UserProduct()
                {
                    Id = 4,
                    UserId = 111,
                    ProductId = 3434
                }
            };
        }

        public Task<List<UserProduct>> GetAllUserProducts()
        {
            return Task.FromResult(userProducts);
        }

        public Task<List<UserProduct>> GetByUserId(int userId)
        {
            return Task.FromResult(userProducts.Where(x => x.UserId == userId).ToList());
        }
    }
}
