using RecommendationsApp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecommendationsApp.Interfaces
{
    internal interface IUserService
    {
        public Task<List<User>> GetAllUsers();
    }
}
