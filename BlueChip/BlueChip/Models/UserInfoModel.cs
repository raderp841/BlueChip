using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BlueChip.Models
{
    public class UserInfoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Your First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter Your Last Name")]
        public string LastName { get; set; }

        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Incorrect email format")]
        [Required(ErrorMessage = "Enter Your Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Your Password")]
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Password must be at leat 8 characters long, have an upper and lowercase letter, a number and a symbol")]

        public string Password { get; set; }
        public string PasswordSalt { get; set; }

        public bool IsAdmin { get; set; }
    }
}