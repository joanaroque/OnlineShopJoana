using System.ComponentModel.DataAnnotations;

namespace OnlineShopJoana.WEB.Models
{
    public class RecoverPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
