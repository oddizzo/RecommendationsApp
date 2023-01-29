using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecommendationsApp.Dtos
{
    internal class UserProduct
    {
        internal int Id { get; set; }
        internal int UserId { get; set; }
        internal int ProductId { get; set; }
    }
}
