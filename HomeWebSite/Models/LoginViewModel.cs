using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWebSite.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Не вказаний логін")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Довжина рядка повинна бути від 3 до 30 символів")]
        [Display(Name = "Введіть логін")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Не вказаний пароль")]
        [DataType(DataType.Password)]
        [StringLength(16, MinimumLength = 4, ErrorMessage = "Довжина пароля повинна бути від 4 до 16 символів")]
        [Display(Name = "Введіть пароль")]
        public string Password { get; set; }

        [Display(Name = "Запам'ятати?")]
        public bool IsRememberMe { get; set; }
        public string ReturnUrl { get; set; }
    }
}
