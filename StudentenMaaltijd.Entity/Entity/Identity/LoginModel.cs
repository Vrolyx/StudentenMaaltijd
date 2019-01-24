using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentenMaaltijd.Entity.Entity.Identity
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email is vereist.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Wachtwoord is vereist.")]
        public string Password { get; set; }
    }
}
