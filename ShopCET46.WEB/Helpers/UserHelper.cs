using Microsoft.AspNetCore.Identity;
using ShopCET46.WEB.Data.Entities;
using ShopCET46.WEB.Models;
using System.Threading.Tasks;

namespace ShopCET46.WEB.Helpers
{
    public class UserHelper : IUserHelper
    {
        //responsavel pelos utilizadores e pelos roles
        private readonly UserManager<User> _userManager;
        //classe que vai ser injetada com o user responsavel por todo o processo do login/logout etc
        private readonly SignInManager<User> _signInManager;
        //sao ambos objetos do Core, que nao necessitam de ser injetados no startup
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserHelper(UserManager<User> userManager,
            SignInManager<User> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public async Task<IdentityResult> AddUserAsync(User user, string password)
        {
            //"bypass"
            return await _userManager.CreateAsync(user, password);
        }

        public async Task AddUSerToRoleAsync(User user, string roleName)
        {
            await _userManager.AddToRoleAsync(user, "Admin");
        }

        public async Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPassword)
        {
            return await _userManager.ChangePasswordAsync(user, oldPassword, newPassword);
        }

        public async Task ChecRoleAsync(string roleName)
        {
            var roleExists = await _roleManager.RoleExistsAsync(roleName);
            if (!roleExists)
            {
                await _roleManager.CreateAsync(new IdentityRole
                {
                    Name = roleName,
                });
            }
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            //"bypass"
            return await _userManager.FindByEmailAsync(email);
        }

        public async Task<bool> IsUserInRoleAsync(User user, string roleName)
        {
            return await _userManager.IsInRoleAsync(user, "Admin");
        }

        public async Task<SignInResult> LoginAsync(LoginViewModel model)
        {
            //implementar os objetos
            return await this._signInManager.PasswordSignInAsync(
                model.UserName,
                model.Password,
                model.RememberMe,
                false);
        }

        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<IdentityResult> UpdateUserAsync(User user)
        {
            return await _userManager.UpdateAsync(user);
        }

        public async Task<SignInResult> ValidatePasswordAsync(User user, string password)
        {
            return await _signInManager.CheckPasswordSignInAsync(
                user,
                password,
                false);
        }

    }
}
