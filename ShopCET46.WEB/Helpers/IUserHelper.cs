using Microsoft.AspNetCore.Identity;
using ShopCET46.WEB.Data.Entities;
using ShopCET46.WEB.Models;
using System.Threading.Tasks;

namespace ShopCET46.WEB.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task<SignInResult> LoginAsync(LoginViewModel model); //Identity

        Task LogoutAsync();
    }
}
