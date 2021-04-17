using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWebSite.Models
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Введіть логін")]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Введіть пароль")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Паролі не співпадають")]
        [DataType(DataType.Password)]
        [Display(Name = "Підтвердіть пароль")]
        public string PasswordConfirm { get; set; }

        [Required]
        [Display(Name = "Введіть ім'я")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Введіть фамілію")]
        public string MiddleName { get; set; }

        [Required]
        [Display(Name = "Введіть електронну пошту")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Введіть номер телефону")]
        public string Phone { get; set; }
    }
}
