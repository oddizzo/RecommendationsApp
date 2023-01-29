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
    internal class UserModule
    {
        private List<User> users;
        private IUserService userService;

        internal UserModule()
        {
            userService = new UserService();
            users = userService.GetAllUsers().Result;      
        }

        internal List<User> getUsers()
        {
            return users.ToList();
        }

        internal User getUserById(int userId)
        {
            return users.Where(x => x.Id == userId).First();
        }
    }
}
