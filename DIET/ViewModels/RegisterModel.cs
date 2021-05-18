using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DIET.ViewModels
{
    public class RegisterModel
    {
        public int id_patient { get; set; }

        [Required(ErrorMessage = "Не указан Email")]
        public string surname { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }

        public string Email { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароль введен неверно")]
        public string ConfirmPassword { get; set; }
    }
}
