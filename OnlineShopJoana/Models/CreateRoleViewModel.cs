using System.ComponentModel.DataAnnotations;

namespace OnlineShopJoana.Models
{
    public class CreateRoleViewModel
    {

        [Required]
        [Display(Name = "Role")]
        public string RoleName { get; set; }
    }
}
