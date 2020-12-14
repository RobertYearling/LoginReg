using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogReg.Models
{
    public class LogReg
    {
        [Required]
        [MinLength(2)]
        [Display(Name="First Name: ")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name="Last Name: ")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name="Email: ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A Password is Required")]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Display(Name="Password: ")]
        public string Password { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Confirm Password required")]
        [CompareAttribute("Password", ErrorMessage = "No Matchie, No Workie")]
        [Display(Name="Confirm Password: ")]
        public string CFPassword { get; set; }
    }
}