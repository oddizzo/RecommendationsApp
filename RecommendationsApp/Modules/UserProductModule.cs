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
    internal class UserProductModule
    {
        private List<UserProduct> users;
        private IUserProductService userProductService;

        internal UserProductModule()
        {
            userProductService = new UserProductService();
        }

        internal List<UserProduct> GetAllUserProducts()
        {
            return userProductService.GetAllUserProducts().Result;
        }

        internal List<UserProduct> GetByUserId(int userId)
        {
            return userProductService.GetByUserId(userId).Result;
        }
    }
}
