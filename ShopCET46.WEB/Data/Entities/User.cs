using Microsoft.AspNetCore.Identity;

namespace ShopCET46.WEB.Data.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        //ver o IdentityUser
    }
}
