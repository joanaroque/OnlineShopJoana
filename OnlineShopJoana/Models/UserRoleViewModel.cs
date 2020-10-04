using System.ComponentModel.DataAnnotations;

namespace OnlineShopJoana.Models
{
    public class UserRoleViewModel
    {

        public string UserId { get; set; }



        public string Name { get; set; }


        [Display(Name = "Email")]
        public string UserName { get; set; }



        public bool IsSelected { get; set; }



        public RoleViewModel Roles { get; set; }
    }
}
