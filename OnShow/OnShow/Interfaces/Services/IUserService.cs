using OnShow.Models;

namespace OnShow.Interfaces.Services
{
    public interface IUserService
    {
        ApplicationUser GetUserById(string id);
    }
}