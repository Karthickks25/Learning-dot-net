using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.Models.Account
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name ="Email Address"), EmailAddress, MaxLength(500)]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage ="Password must match")]
        [Display(Name ="Confirm password")]
        public string ConfirmPassword { get; set; }

        [Display(Name ="Remember me")]
        public bool RememberMe { get; set; }
    }
}
