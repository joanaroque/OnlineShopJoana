﻿using Microsoft.AspNetCore.Authentication;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineShopJoana.WEB.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string UserName { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }


        public bool RememberMe { get; set; }


        public string ReturnUrl { get; set; }


        public IList<AuthenticationScheme> ExternalLogins { get; set; }
    }
}
