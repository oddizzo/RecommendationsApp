using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using RecommendationsApp.Dtos;
using RecommendationsApp.Interfaces;
using RecommendationsApp.Services;

namespace RecommendationsApp.Modules
{
    internal class RecommendationsEngine
    {
        private List<Product> products;
        private List<User> users;
        private List<UserProduct> userProducts;

        internal RecommendationsEngine(List<Product> _products, List<User> _users, List<UserProduct> _userProducts)
        {
            products = _products;
            users = _users;
            userProducts = _userProducts;
        }

        internal List<Product> Recommend(int userId)
        {
            var recommendations = new List<Product>();

            var userIdProducts = userProducts.Where(x => x.UserId == userId);

            foreach (var userProduct in userIdProducts)
            {
                int productId = userProduct.ProductId;
                string productCat = products.Where(x => x.Id == productId).First().Category;
                recommendations.AddRange(products.Where(x => x.Category == productCat && x.Id != productId));
            }

            return recommendations.ToList();
        }




    }
}
