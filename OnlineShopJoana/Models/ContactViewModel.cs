using System.ComponentModel.DataAnnotations;

namespace OnlineShopJoana.Models
{
    public class ContactViewModel
    {
        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "The field {0} only can contains {1} characters length.")]
        public string Name { get; set; }


        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        public string Subject { get; set; }


        [Required]
        public string Message { get; set; }

    }
}
