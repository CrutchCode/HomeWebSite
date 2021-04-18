using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWebSite.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Не введене ім'я!")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Довжина рядка повинна бути від 3 до 30 символів")]
        [Display(Name = "Введіть логін")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Не вказаний пароль!")]
        [DataType(DataType.Password)]
        [StringLength(16, MinimumLength = 4, ErrorMessage = "Довжина пароля повинна бути від 4 до 16 символів")]
        [Display(Name = "Введіть пароль")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Не підтверджений пароль!")]
        [Compare("Password", ErrorMessage = "Паролі не співпадають!")]
        [DataType(DataType.Password)]
        [StringLength(16, MinimumLength = 4, ErrorMessage = "Довжина пароля повинна бути від 4 до 16 символів")]
        [Display(Name = "Підтвердіть пароль")]
        public string PasswordConfirm { get; set; }

        [Required(ErrorMessage = "Не вказаний логін!")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Довжина рядка повинна бути від 3 до 30 символів")]
        [Display(Name = "Введіть ім'я")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Не введена фамілія!")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Довжина рядка повинна бути від 3 до 30 символів")]
        [Display(Name = "Введіть фамілію")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Не введена електронна пошта!")]
        [EmailAddress(ErrorMessage = "Некоректна поштова адреса")]
        [Display(Name = "Введіть електронну пошту")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Не введений номер телефону!")]
        //[Phone(ErrorMessage ="Некоректний номер телефону")]
        [Display(Name = "Введіть номер телефону")]
        public string Phone { get; set; }
    }
}
