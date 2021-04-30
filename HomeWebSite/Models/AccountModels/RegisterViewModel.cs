using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWebSite.Models.AccountModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "No name entered!")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Line length must be between 3 and 30 characters")]
        [Display(Name = "Enter your login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "No password specified!")]
        [DataType(DataType.Password)]
        [StringLength(16, MinimumLength = 4, ErrorMessage = "The password must be between 4 and 16 characters")]
        [Display(Name = "Enter the password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password not confirmed!")]
        [Compare("Password", ErrorMessage = "Passwords do not match!")]
        [DataType(DataType.Password)]
        [StringLength(16, MinimumLength = 4, ErrorMessage = "The password must be between 4 and 16 characters")]
        [Display(Name = "Confirm password")]
        public string PasswordConfirm { get; set; }

        [Required(ErrorMessage = "No login specified!")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Line length must be between 3 and 30 characters")]
        [Display(Name = "Enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Middle name not entered!")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Line length must be between 3 and 30 characters")]
        [Display(Name = "Enter Middle name")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Email not entered!")]
        [EmailAddress(ErrorMessage = "Invalid mailing address")]
        [Display(Name = "Enter your email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "No phone number entered!")]
        //[Phone(ErrorMessage ="Некоректний номер телефону")]
        [Display(Name = "Enter the phone number")]
        public string Phone { get; set; }
    }
}
