using System.ComponentModel.DataAnnotations;

namespace ShopCET46.WEB.Models
{
    public class RecoverPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
