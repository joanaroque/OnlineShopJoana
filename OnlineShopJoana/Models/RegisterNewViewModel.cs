﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineShopJoana.WEB.Models
{
    public class RegisterNewViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [MaxLength(100, ErrorMessage = "The field {0} only can contain {1} characters.")]
        public string Address { get; set; }


        [MaxLength(20, ErrorMessage = "The field {0} only can contain {1} characters.")]
        public string PhoneNumber { get; set; }


        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string Confirm { get; set; }
    }
}
