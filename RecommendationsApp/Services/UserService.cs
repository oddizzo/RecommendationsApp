using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecommendationsApp.Dtos;
using RecommendationsApp.Interfaces;

namespace RecommendationsApp.Services
{
    internal class UserService : IUserService
    {
        private readonly List<User> users;

        internal UserService()
        {
            users = new List<User>()
            {
                new User()
                {
                    Id = 111,
                    Name = "William Smith"
                },
                new User()
                {
                    Id = 222,
                    Name = "Steve Brown"
                },
                new User()
                {
                    Id = 333,
                    Name = "Kygo Valerie"
                }
            };
        }

        public Task<List<User>> GetAllUsers()
        {
            return Task.FromResult(users);
        }
    }
}
