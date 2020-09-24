using System.ComponentModel.DataAnnotations;

namespace ShopCET46.WEB.Models
{
    public class ChangePasswordViewModel
    {
        [Required]
        [Display(Name = "Current Password")]
        public string OldPassword { get; set; }

        [Required]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }

        [Required]
        [Compare("Password")]
        public string Confirm { get; set; }
    }
}
