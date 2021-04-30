using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace HomeWebSite.Models.AccountModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Login not specified")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Line length must be between 3 and 30 characters")]
        [Display(Name = "Enter your login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "No password specified")]
        [DataType(DataType.Password)]
        [StringLength(16, MinimumLength = 4, ErrorMessage = "The password must be between 4 and 16 characters")]
        [Display(Name = "Enter the password")]
        public string Password { get; set; }

        [Display(Name = "Remember?")]
        public bool IsRememberMe { get; set; }
        public string ReturnUrl { get; set; }
    }
}
