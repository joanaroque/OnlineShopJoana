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

        Task<IdentityResult> UpdateUserAsync(User user);

        Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPassword);

        Task<SignInResult> ValidatePasswordAsync(User user, string password); // ve se o user ta certo com a pass que ele disse
       
        Task ChecRoleAsync(string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);


        Task AddUSerToRoleAsync(User user, string roleName);
    }
}
