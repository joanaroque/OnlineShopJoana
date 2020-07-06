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

        public UserHelper(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IdentityResult> AddUserAsync(User user, string password)
        {
            //"bypass"
            return await _userManager.CreateAsync(user, password);
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            //"bypass"
            return await _userManager.FindByEmailAsync(email);
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
    }
}
