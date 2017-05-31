using OnShow.Interfaces.Services;
using OnShow.Models;
using System.Linq;

namespace OnShow.Services
{
    public class UserService : IUserService
    {
        public ApplicationUser GetUserById(string id)
        {
            using (var db = new ApplicationDbContext())
            {
                var user = db.Users.SingleOrDefault(u => u.Id == id);

                return user;
            }
        }
    }
}