using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentenMaaltijd.Entity.Entity.Identity
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "U moet een naam invullen")]
        public string Name { get; set; }
        [Required(ErrorMessage = "U moet een email invullen")]
        [EmailAddress(ErrorMessage = "U moet een valide email invullen")]
        public string Email { get; set; }
        [Required(ErrorMessage = "U moet een telefoonnummer invullen")]
        [RegularExpression(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}", ErrorMessage = "U moet een valide telefoonnummer invullen")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "U moet een wachtwoord invullen")]
        public string Password { get; set; }
    }
}
