using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWebSite.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Введіть логін")]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Введіть пароль")]
        public string Password { get; set; }

        [Display(Name = "Запам'ятати?")]
        public bool IsRememberMe { get; set; }
        public string ReturnUrl { get; set; }
    }
}
